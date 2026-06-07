using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EmitirFactura
{
    internal class EmisionFacturaModelo
    {
        public List<GuiasPendientes> LGuiasPendientes
        {
            get
            {
                return new List<GuiasPendientes>
                {
                    //Esta clase representa las guias pendientes de facturacion, Cada guia tiene un Id unico, un clienteID 
                    //sruge en realidad de la clase CC de Clientes, guia id, fecha de entrega, fecha de movimiento, 
                    //precio de imposicion, transporte, entrega y total. Un boolean que indique si ya fue facturada
                    // y un string con el numero de cocumento una vez facturada.

                    new GuiasPendientes { Id = 1, clienteID = 1, numeroGuia = 001, fechaEntrega = new DateTime(2026, 04, 05), importe = 15000 },
                    new GuiasPendientes { Id = 2, clienteID = 2, numeroGuia = 002, fechaEntrega = new DateTime(2026, 04, 06), importe = 10000 },
                    new GuiasPendientes { Id = 3, clienteID = 3, numeroGuia = 003, fechaEntrega = new DateTime(2026, 04, 07), importe = 6000 },
                    new GuiasPendientes { Id = 4, clienteID = 4, numeroGuia = 004, fechaEntrega = new DateTime(2026, 04, 08), importe = 20000 },
                    new GuiasPendientes { Id = 5, clienteID = 5, numeroGuia = 005, fechaEntrega = new DateTime(2026, 04, 09), importe = 11000 },
                    new GuiasPendientes { Id = 6, clienteID = 6, numeroGuia = 006, fechaEntrega = new DateTime(2026, 04, 10), importe = 7000 },
                    new GuiasPendientes { Id = 7, clienteID = 1, numeroGuia = 007, fechaEntrega = new DateTime(2026, 04, 11), importe = 19000 },
                    new GuiasPendientes { Id = 8, clienteID = 2, numeroGuia = 008, fechaEntrega = new DateTime(2026, 04, 12), importe = 14000 },
                    new GuiasPendientes { Id = 9, clienteID = 3, numeroGuia = 009, fechaEntrega = new DateTime(2026, 04, 13), importe = 9500 },
                    new GuiasPendientes { Id = 10, clienteID = 4, numeroGuia = 010, fechaEntrega = new DateTime(2026, 04, 14), importe = 7500 },
                    new GuiasPendientes { Id = 11, clienteID = 1, numeroGuia = 011, fechaEntrega = new DateTime(2026, 04, 15), importe = 20000 },
                    new GuiasPendientes { Id = 12, clienteID = 2, numeroGuia = 012, fechaEntrega = new DateTime(2026, 04, 16), importe = 15000 },
                    new GuiasPendientes { Id = 13, clienteID = 3, numeroGuia = 013, fechaEntrega = new DateTime(2026, 04, 17), importe = 10000 },
                    new GuiasPendientes { Id = 14, clienteID = 4, numeroGuia = 014, fechaEntrega = new DateTime(2026, 04, 18), importe = 6000 },
                    new GuiasPendientes { Id = 15, clienteID = 1, numeroGuia = 015, fechaEntrega = new DateTime(2026, 04, 19), importe = 20000 },
                    new GuiasPendientes { Id = 16, clienteID = 2, numeroGuia = 016, fechaEntrega = new DateTime(2026, 04, 20), importe = 14000 },
                    new GuiasPendientes { Id = 17, clienteID = 3, numeroGuia = 017, fechaEntrega = new DateTime(2026, 04, 21), importe = 11000 },
                    new GuiasPendientes { Id = 18, clienteID = 4, numeroGuia = 018, fechaEntrega = new DateTime(2026, 04, 22), importe = 7000 },
                    new GuiasPendientes { Id = 19, clienteID = 5, numeroGuia = 019, fechaEntrega = new DateTime(2026, 04, 23), importe = 19000 },
                    new GuiasPendientes { Id = 20, clienteID = 1, numeroGuia = 020, fechaEntrega = new DateTime(2026, 04, 24), importe = 15000 }
                };
            }
        }
        public List<Clientes> LClientes =>
        ClienteAlmacen.clientes.Select(c => new Clientes
        {
            clienteId = c.ClienteId,
            clienteName = string.IsNullOrEmpty(c.RazonSocial)
                          ? $"{c.Nombre} {c.Apellido}"
                          : c.RazonSocial,
            clienteCUIT = c.Cuit
        }).ToList();
        public List<Documentos> LDocumentos =>
        DocumentoAlmacen.documentos.Select(d => new Documentos
        {
            documentoId = d.DocumentoId,
            clienteId = d.ClienteId,
            documentoTipo = d.TipoDocumento.ToString(),
            documentoFecha = d.FechaDocumento,
            documentoNumero = d.NumeroDocumento,
            netoGravado = d.NetoGravado,
            ivaDF = d.IvaDF,
            documentoTotal = d.Total
        }).ToList();

        public List<Guias> LGuias =>
            GuiaAlmacen.guias.Select(g => new Guias
            {
                guiaId = g.GuiaId,
                clienteId = g.ClienteId,
                apellidoDestinatario = g.ApellidoDestinatario,
                nombreDestinatario = g.NombreDestinatario,
                tipoCaja = g.TipoCaja.ToString(),
                tarifarioId = g.TarifarioId
            }).ToList();
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