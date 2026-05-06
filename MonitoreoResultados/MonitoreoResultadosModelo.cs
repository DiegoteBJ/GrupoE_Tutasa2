using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.MonitoreoResultados
{
    internal class MonitoreoResultadosModelo
    {
        public List<Documentos> LDocumentos
        {
            get
            {
                return new List<Documentos>
                {
                    new Documentos { documentoId = 1, proveedorId = 1, documentoTipo = "FC", documentoFecha = new DateTime(2026, 03, 05), documentoNumero = "FC00000001", documentoTotalsinIVA = 150000 },
                    new Documentos { documentoId = 2, proveedorId = 2, documentoTipo = "FC", documentoFecha = new DateTime(2026, 03, 06), documentoNumero = "FC00000002", documentoTotalsinIVA = 100000 },
                    new Documentos { documentoId = 3, proveedorId = 3, documentoTipo = "FC", documentoFecha = new DateTime(2026, 03, 07), documentoNumero = "FC00000003", documentoTotalsinIVA = 60000 },
                    new Documentos { documentoId = 4, proveedorId = 2, documentoTipo = "NC", documentoFecha = new DateTime(2026, 03, 08), documentoNumero = "NC00000004", documentoTotalsinIVA = -200000 },
                    new Documentos { documentoId = 5, proveedorId = 5, documentoTipo = "FC", documentoFecha = new DateTime(2026, 03, 09), documentoNumero = "FC00000005", documentoTotalsinIVA = 110000 },
                    new Documentos { documentoId = 6, proveedorId = 6, documentoTipo = "FC", documentoFecha = new DateTime(2026, 04, 10), documentoNumero = "FC00000006", documentoTotalsinIVA = 70000 },
                    new Documentos { documentoId = 7, proveedorId = 1, documentoTipo = "NC", documentoFecha = new DateTime(2026, 04, 11), documentoNumero = "NC00000005", documentoTotalsinIVA = -190000 },
                    new Documentos { documentoId = 8, proveedorId = 2, documentoTipo = "NC", documentoFecha = new DateTime(2026, 04, 12), documentoNumero = "NC00000006", documentoTotalsinIVA = -140000 },
                    new Documentos { documentoId = 9, proveedorId = 3, documentoTipo = "FC", documentoFecha = new DateTime(2026, 04, 13), documentoNumero = "FC00000007", documentoTotalsinIVA = 9500 },
                    new Documentos { documentoId = 10, proveedorId = 4, documentoTipo = "FC", documentoFecha = new DateTime(2026, 04, 14), documentoNumero = "FC00000008", documentoTotalsinIVA = 85000 },
                    new Documentos { documentoId = 11, proveedorId = 5, documentoTipo = "NC", documentoFecha = new DateTime(2026, 04, 15), documentoNumero = "NC00000007", documentoTotalsinIVA = -32000 },
                    new Documentos { documentoId = 12, proveedorId = 6, documentoTipo = "ND", documentoFecha = new DateTime(2026, 04, 16), documentoNumero = "ND00000001", documentoTotalsinIVA = 47500 },
                    new Documentos { documentoId = 13, proveedorId = 1, documentoTipo = "FC", documentoFecha = new DateTime(2026, 04, 17), documentoNumero = "FC00000009", documentoTotalsinIVA = 220000 },
                    new Documentos { documentoId = 14, proveedorId = 3, documentoTipo = "ND", documentoFecha = new DateTime(2026, 04, 18), documentoNumero = "ND00000002", documentoTotalsinIVA = 18000 },
                    new Documentos { documentoId = 15, proveedorId = 4, documentoTipo = "NC", documentoFecha = new DateTime(2026, 04, 19), documentoNumero = "NC00000008", documentoTotalsinIVA = -55000 },
                };
            }
        }
        public List<ProveedoresLD> LProveedoresLD
        {
            get
            {
                return new List<ProveedoresLD>
                {
                    new ProveedoresLD { proveedorId = 1, proveedorName = "Chevallier", proveedorCUIT = 30654364229 },
                    new ProveedoresLD { proveedorId = 2, proveedorName = "Andesmar", proveedorCUIT = 27202016494 },
                    new ProveedoresLD { proveedorId = 3, proveedorName = "Flechabus", proveedorCUIT = 20483900334 },
                    new ProveedoresLD { proveedorId = 4, proveedorName = "Crucero del Norte", proveedorCUIT = 20483900342 },
                    new ProveedoresLD { proveedorId = 5, proveedorName = "La Veloz del Norte", proveedorCUIT = 20329642330 },
                    new ProveedoresLD { proveedorId = 6, proveedorName = "Via Bariloche", proveedorCUIT = 27384592017 },
                    new ProveedoresLD { proveedorId = 7, proveedorName = "Plusmar", proveedorCUIT = 30765432109 },
                    new ProveedoresLD { proveedorId = 8, proveedorName = "El Rapido Argentino", proveedorCUIT = 23345678903 },
                    new ProveedoresLD { proveedorId = 9, proveedorName = "Empresa 20 de Junio", proveedorCUIT = 30789123456 },
                    new ProveedoresLD { proveedorId = 10, proveedorName = "General Urquiza", proveedorCUIT = 20345678901 },
                };
            }
        }
    }
}

