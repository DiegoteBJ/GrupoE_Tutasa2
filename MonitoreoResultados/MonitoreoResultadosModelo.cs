using GrupoE_Tutasa.EmitirFactura;
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
        public List<Guias> LGuias
        {
            get
            {
                return new List<Guias>
                {
                    new Guias { Id = 1, clienteID = 1, numeroGuia = "G001", fechaEntrega = new DateTime(2026, 04, 05), origen = "Buenos Aires", destino = "Rosario", tamaño = "L", importeImposicion = 5000, importeEntrega = 5000, importeTransporte = 7000, importeTotal = 17000, proveedorTransporteId = 1 },
                    new Guias { Id = 2, clienteID = 2, numeroGuia = "G002", fechaEntrega = new DateTime(2026, 04, 06), origen = "Córdoba", destino = "Mendoza", tamaño = "M", importeImposicion = 0, importeEntrega = 0, importeTransporte = 8500, importeTotal = 8500 , proveedorTransporteId = 2 },
                    new Guias { Id = 3, clienteID = 3, numeroGuia = "G003", fechaEntrega = new DateTime(2026, 04, 07), origen = "La Plata", destino = "Mar del Plata", tamaño = "S", importeImposicion = 0, importeEntrega = 0, importeTransporte = 6000, importeTotal = 6000 , proveedorTransporteId = 3 },
                    new Guias { Id = 4, clienteID = 4, numeroGuia = "G004", fechaEntrega = new DateTime(2026, 04, 08), origen = "San Juan", destino = "Salta", tamaño = "XL", importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 20000, importeTotal = 35000 , proveedorTransporteId = 4 },
                    new Guias { Id = 5, clienteID = 5, numeroGuia = "G005", fechaEntrega = new DateTime(2026, 04, 09), origen = "Neuquén", destino = "Bahía Blanca", tamaño = "M", importeImposicion = 5000, importeEntrega = 0, importeTransporte = 11000, importeTotal = 16000 , proveedorTransporteId = 2 },
                    new Guias { Id = 6, clienteID = 6, numeroGuia = "G006", fechaEntrega = new DateTime(2026, 04, 10), origen = "Tucumán", destino = "Santa Fe", tamaño = "S", importeImposicion = 0, importeEntrega = 5000, importeTransporte = 7000, importeTotal = 12000 , proveedorTransporteId = 3 },
                    new Guias { Id = 7, clienteID = 1, numeroGuia = "G007", fechaEntrega = new DateTime(2026, 04, 11), origen = "Corrientes", destino = "Posadas", tamaño = "XL", importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 19000, importeTotal = 34000 , proveedorTransporteId = 7 },
                    new Guias { Id = 8, clienteID = 2, numeroGuia = "G008", fechaEntrega = new DateTime(2026, 04, 12), origen = "Resistencia", destino = "San Luis", tamaño = "L", importeImposicion = 0, importeEntrega = 5000, importeTransporte = 14000, importeTotal = 19000 , proveedorTransporteId = 5 },
                    new Guias { Id = 9, clienteID = 3, numeroGuia = "G009", fechaEntrega = new DateTime(2026, 04, 13), origen = "Catamarca", destino = "Jujuy", tamaño = "M", importeImposicion = 5000, importeEntrega = 0, importeTransporte = 9000, importeTotal = 14000 , proveedorTransporteId = 6 },
                    new Guias { Id = 10, clienteID = 4, numeroGuia = "G010", fechaEntrega = new DateTime(2026, 04, 14), origen = "Trelew", destino = "Río Gallegos", tamaño = "S", importeImposicion = 0, importeEntrega = 0, importeTransporte = 7500, importeTotal = 7500, proveedorTransporteId = 2  },
                    new Guias { Id = 11, clienteID = 1, numeroGuia = "G011", fechaEntrega = new DateTime(2026, 04, 15), origen = "Buenos Aires", destino = "Rosario", tamaño = "XL", importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 20000, importeTotal = 35000, proveedorTransporteId = 1  },
                    new Guias { Id = 12, clienteID = 2, numeroGuia = "G012", fechaEntrega = new DateTime(2026, 04, 16), origen = "Córdoba", destino = "Mendoza", tamaño = "L", importeImposicion = 0, importeEntrega = 5000, importeTransporte = 15000, importeTotal = 20000 , proveedorTransporteId = 1},
                    new Guias { Id = 13, clienteID = 3, numeroGuia = "G013", fechaEntrega = new DateTime(2026, 04, 17), origen = "La Plata", destino = "Mar del Plata", tamaño = "M", importeImposicion = 5000, importeEntrega = 0, importeTransporte = 10000, importeTotal = 15000 , proveedorTransporteId = 1},
                    new Guias { Id = 14, clienteID = 4, numeroGuia = "G014", fechaEntrega = new DateTime(2026, 04, 18), origen = "San Juan", destino = "Salta", tamaño = "S", importeImposicion = 0, importeEntrega = 0, importeTransporte = 6000, importeTotal = 6000 , proveedorTransporteId = 6},
                    new Guias { Id = 15, clienteID = 1, numeroGuia = "G015", fechaEntrega = new DateTime(2026, 04, 19), origen = "Neuquén", destino = "Bahía Blanca", tamaño = "XL", importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 20000, importeTotal = 35000 , proveedorTransporteId = 3},
                    new Guias { Id = 16, clienteID = 2, numeroGuia = "G016", fechaEntrega = new DateTime(2026, 04, 20), origen = "Tucumán", destino = "Santa Fe", tamaño = "L", importeImposicion = 0, importeEntrega = 5000, importeTransporte = 14000, importeTotal = 19000 , proveedorTransporteId = 5},
                    new Guias { Id = 17, clienteID = 3, numeroGuia = "G017", fechaEntrega = new DateTime(2026, 04, 21), origen = "Corrientes", destino = "Posadas", tamaño = "M", importeImposicion = 5000, importeEntrega = 0, importeTransporte = 11000, importeTotal = 16000 , proveedorTransporteId = 2},
                    new Guias { Id = 18, clienteID = 4, numeroGuia = "G018", fechaEntrega = new DateTime(2026, 04, 22), origen = "Resistencia", destino = "San Luis", tamaño = "S", importeImposicion = 0, importeEntrega = 5000, importeTransporte = 7000, importeTotal = 12000 , proveedorTransporteId = 6},
                    new Guias { Id = 19, clienteID = 5, numeroGuia = "G019", fechaEntrega = new DateTime(2026, 04, 23), origen = "Catamarca", destino = "Jujuy", tamaño = "XL", importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 19000, importeTotal = 34000 , proveedorTransporteId = 5},
                    new Guias { Id = 20, clienteID = 1, numeroGuia = "G020", fechaEntrega = new DateTime(2026, 04, 24), origen = "Trelew", destino = "Río Gallegos", tamaño = "L", importeImposicion = 0, importeEntrega = 5000, importeTransporte = 15000, importeTotal = 20000 , proveedorTransporteId = 3}
                };
            }
        }
    }
}

