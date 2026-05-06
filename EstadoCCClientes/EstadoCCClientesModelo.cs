using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EstadoCCClientes
{
    internal class EstadoCCClientesModelo
    {
        public List<Clientes> LClientes
        {
            get
            {
                return new List<Clientes>
                {
                    new Clientes { clienteId = 1, clienteName = "Cliente A", clienteCUIT = 30654364229 },
                    new Clientes { clienteId = 2, clienteName = "Cliente B", clienteCUIT = 27202016494 },
                    new Clientes { clienteId = 3, clienteName = "Cliente C", clienteCUIT = 20483900334 },
                    new Clientes { clienteId = 4, clienteName = "Cliente D", clienteCUIT = 20483900342 },
                    new Clientes { clienteId = 5, clienteName = "Cliente E", clienteCUIT = 20329642330 },
                    new Clientes { clienteId = 6, clienteName = "Cliente F", clienteCUIT = 27384592017 },
                    new Clientes { clienteId = 7, clienteName = "Cliente G", clienteCUIT = 30765432109 },
                    new Clientes { clienteId = 8, clienteName = "Cliente H", clienteCUIT = 23345678903 },
                    new Clientes { clienteId = 9, clienteName = "Cliente I", clienteCUIT = 30789123456 },
                    new Clientes { clienteId = 10, clienteName = "Cliente J", clienteCUIT = 20345678901 },
                };
            }
        }
        public List<Documentos> LDocumentos
        {
            get
            {
                return new List<Documentos>
                {
                    new Documentos { documentoId = 1, clienteId = 1, documentoTipo = "FC", documentoFecha = new DateTime(2026, 01, 05), documentoNumero = "FC00000001", documentoTotal = 15000 },
                    new Documentos { documentoId = 2, clienteId = 2, documentoTipo = "FC", documentoFecha = new DateTime(2026, 01, 06), documentoNumero = "FC00000002", documentoTotal = 10000 },
                    new Documentos { documentoId = 3, clienteId = 3, documentoTipo = "FC", documentoFecha = new DateTime(2026, 01, 07), documentoNumero = "FC00000003", documentoTotal = 6000 },
                    new Documentos { documentoId = 4, clienteId = 2, documentoTipo = "NC", documentoFecha = new DateTime(2026, 01, 08), documentoNumero = "NC00000004", documentoTotal = -20000 },
                    new Documentos { documentoId = 5, clienteId = 5, documentoTipo = "FC", documentoFecha = new DateTime(2026, 01, 09), documentoNumero = "FC00000005", documentoTotal = 11000 },
                    new Documentos { documentoId = 6, clienteId = 6, documentoTipo = "FC", documentoFecha = new DateTime(2026, 01, 10), documentoNumero = "FC00000006", documentoTotal = 7000 },
                    new Documentos { documentoId = 7, clienteId = 1, documentoTipo = "RC", documentoFecha = new DateTime(2026, 01, 11), documentoNumero = "RC00001235", documentoTotal = -19000 },
                    new Documentos { documentoId = 8, clienteId = 2, documentoTipo = "RC", documentoFecha = new DateTime(2026, 01, 12), documentoNumero = "RC00002758", documentoTotal = -14000 },
                    new Documentos { documentoId = 9, clienteId = 3, documentoTipo = "FC", documentoFecha = new DateTime(2026, 01, 13), documentoNumero = "FC00000007", documentoTotal = 950 },
                };

            }
        }
    }
}
