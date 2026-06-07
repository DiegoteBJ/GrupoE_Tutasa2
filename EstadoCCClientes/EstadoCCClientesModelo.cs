using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EstadoCCClientes
{
    internal class EstadoCCClientesModelo
    {
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
            documentoTotal = d.Total
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
