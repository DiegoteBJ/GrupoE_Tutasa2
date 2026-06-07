using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.EmitirFactura
{
    internal class EmisionFacturaModelo
    {
        public List<GuiasPendientes> LGuiasPendientes =>
            CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes
                .Where(cc => !cc.Facturado
                          && cc.FechaEntrega.Month == DateTime.Now.AddMonths(-1).Month
                          && cc.FechaEntrega.Year == DateTime.Now.AddMonths(-1).Year)
                .Select(cc => new GuiasPendientes
                {
                    Id                  = cc.CcClienteId,
                    clienteID           = cc.ClienteId,
                    numeroGuia          = cc.GuiaId,
                    fechaEntrega        = cc.FechaEntrega,
                    fechaMovimiento     = cc.FechaMovimiento,
                    precioImposicion    = cc.PrecioImposicion,
                    precioEntrega       = cc.PrecioEntrega,
                    precioTransporte    = cc.PrecioTransporte,
                    importe             = cc.PrecioCalculadoTotal,
                    empresaTransporteID = cc.EmpresaTransporteId,
                    facturada           = cc.Facturado,
                    documentoNumero     = string.Empty
                }).ToList();

        public List<Clientes> LClientes =>
            ClienteAlmacen.clientes.Select(c => new Clientes
            {
                clienteId   = c.ClienteId,
                clienteName = string.IsNullOrEmpty(c.RazonSocial)
                              ? $"{c.Nombre} {c.Apellido}"
                              : c.RazonSocial,
                clienteCUIT = c.Cuit
            }).ToList();

        public List<Documentos> LDocumentos =>
            DocumentoAlmacen.documentos.Select(d => new Documentos
            {
                documentoId     = d.DocumentoId,
                clienteId       = d.ClienteId,
                documentoTipo   = d.TipoDocumento.ToString(),
                documentoFecha  = d.FechaDocumento,
                documentoNumero = d.NumeroDocumento,
                netoGravado     = d.NetoGravado,
                ivaDF           = d.IvaDF,
                documentoTotal  = d.Total
            }).ToList();

        public List<Guias> LGuias =>
            GuiaAlmacen.guias.Select(g => new Guias
            {
                guiaId               = g.GuiaId,
                clienteId            = g.ClienteId,
                apellidoDestinatario = g.ApellidoDestinatario,
                nombreDestinatario   = g.NombreDestinatario,
                tipoCaja             = g.TipoCaja.ToString(),
                tarifarioId          = g.TarifarioId
            }).ToList();

        public string EmitirFactura(int clienteId, decimal netoGravado)
        {
            int nuevoDocumentoId = DocumentoAlmacen.documentos.Count > 0
                ? DocumentoAlmacen.documentos.Max(d => d.DocumentoId) + 1
                : 1;

            string numeroDocumento  = $"{nuevoDocumentoId:00000000}";
            decimal iva             = netoGravado * 0.21m;
            decimal documentoTotal  = netoGravado + iva;

            var nuevoDocumento = new DocumentoEntidad
            {
                DocumentoId     = nuevoDocumentoId,
                ClienteId       = clienteId,
                TipoDocumento   = TipoDocumentoEnum.FC,
                FechaDocumento  = DateTime.Now,
                NumeroDocumento = numeroDocumento,
                NetoGravado     = netoGravado,
                IvaDF           = iva,
                Total           = documentoTotal
            };

            DocumentoAlmacen.documentos.Add(nuevoDocumento);
            DocumentoAlmacen.Guardar();

            MarcarGuiasComoFacturadas(clienteId, numeroDocumento);

            return numeroDocumento;
        }

        public void MarcarGuiasComoFacturadas(int clienteId, string numeroDocumento)
        {
            var registros = CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes
                .Where(cc => cc.ClienteId == clienteId
                          && !cc.Facturado
                          && cc.FechaEntrega.Month == DateTime.Now.AddMonths(-1).Month
                          && cc.FechaEntrega.Year == DateTime.Now.AddMonths(-1).Year);

            var documento = DocumentoAlmacen.documentos
                .FirstOrDefault(d => d.NumeroDocumento == numeroDocumento);

            foreach (var cc in registros)
            {
                cc.Facturado       = true;
                cc.DocumentoId     = documento?.DocumentoId ?? 0;
                cc.FechaMovimiento = DateTime.Now;
            }
            CuentaCorrienteClienteAlmacen.Guardar();
        }

        public static bool ValidarCuit(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit)) return false;

            cuit = new string(cuit.Where(char.IsDigit).ToArray());

            if (cuit.Length != 11) return false;

            int prefijo = int.Parse(cuit[..2]);
            if (!new[] { 20, 23, 24, 27, 30, 33, 34 }.Contains(prefijo)) return false;

            int[] coef = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
                suma += (cuit[i] - '0') * coef[i];

            int resto = suma % 11;
            if (resto == 1) return false;

            int esperado = resto == 0 ? 0 : 11 - resto;
            return (cuit[10] - '0') == esperado;
        }
    }
}
