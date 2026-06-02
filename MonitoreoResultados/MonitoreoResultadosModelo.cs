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
                    new ProveedoresLD { proveedorId = 1, proveedorName = "Chevallier", proveedorCUIT = "30654364229", montoFijoMensual = 100000m },
                    new ProveedoresLD { proveedorId = 2, proveedorName = "Andesmar", proveedorCUIT = "27202016494", montoFijoMensual = 150000m },
                    new ProveedoresLD { proveedorId = 3, proveedorName = "Flechabus", proveedorCUIT = "20483900334", montoFijoMensual = 200000m },
                    new ProveedoresLD { proveedorId = 4, proveedorName = "Crucero del Norte", proveedorCUIT = "20483900342", montoFijoMensual = 50000m },
                    new ProveedoresLD { proveedorId = 5, proveedorName = "La Veloz del Norte", proveedorCUIT = "20329642330", montoFijoMensual = 30000m },
                    new ProveedoresLD { proveedorId = 6, proveedorName = "Via Bariloche", proveedorCUIT = "27384592017", montoFijoMensual = 150000m },
                    new ProveedoresLD { proveedorId = 7, proveedorName = "Plusmar", proveedorCUIT = "30765432109", montoFijoMensual = 400000m },
                    new ProveedoresLD { proveedorId = 8, proveedorName = "El Rapido Argentino", proveedorCUIT = "23345678903", montoFijoMensual = 250000m },
                    new ProveedoresLD { proveedorId = 9, proveedorName = "Empresa 20 de Junio", proveedorCUIT = "30789123456", montoFijoMensual = 100000m },
                    new ProveedoresLD { proveedorId = 10, proveedorName = "General Urquiza", proveedorCUIT = "20345678901", montoFijoMensual = 80000m },
                };
            }
        }
        public List<Guias> LGuias
        // Esta clase representa las guías que tienen estado de entregadas y facturadas.
        // Por las modificaciones que se hicieron en el diagrama de clases, surge en realidad de la clase CuentaCorriente
        // que almacena los datos de las guias a partir de la admision de cada encomienda y almacena estos datos.
        // para que esté entregada y facturada debe tener: facturada = true, fechaEntrega != null y documentoId != 0
        {
            get
            {
                return new List<Guias>
                {
                    new Guias { clienteID = 1, numeroGuia = 001, fechaEntrega = new DateTime(2026, 04, 05), importeImposicion = 5000, importeEntrega = 5000, importeTransporte = 7000, importeTotal = 17000, proveedorTransporteId = 1, facturada = true, documentoId = 0 },
                    new Guias { clienteID = 2, numeroGuia = 002, fechaEntrega = new DateTime(2026, 04, 06), importeImposicion = 0, importeEntrega = 0, importeTransporte = 8500, importeTotal = 8500 , proveedorTransporteId = 2 , facturada = true, documentoId = 0},
                    new Guias { clienteID = 3, numeroGuia = 003, fechaEntrega = new DateTime(2026, 04, 07), importeImposicion = 0, importeEntrega = 0, importeTransporte = 6000, importeTotal = 6000 , proveedorTransporteId = 3 , facturada = true, documentoId = 0},
                    new Guias {clienteID = 4, numeroGuia = 004, fechaEntrega = new DateTime(2026, 04, 08), importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 20000, importeTotal = 35000, proveedorTransporteId = 4, facturada = true, documentoId = 0},
                    new Guias {clienteID = 5, numeroGuia = 005, fechaEntrega = new DateTime(2026, 04, 09), importeImposicion = 5000, importeEntrega = 0, importeTransporte = 11000, importeTotal = 16000, proveedorTransporteId = 2, facturada = true, documentoId = 0},
                    new Guias {clienteID = 6, numeroGuia = 006, fechaEntrega = new DateTime(2026, 04, 10), importeImposicion = 0, importeEntrega = 5000, importeTransporte = 7000, importeTotal = 12000, proveedorTransporteId = 3, facturada = true, documentoId = 0},
                    new Guias {clienteID = 1, numeroGuia = 007, fechaEntrega = new DateTime(2026, 04, 11), importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 19000, importeTotal = 34000, proveedorTransporteId = 7, facturada = true, documentoId = 0},
                    new Guias {clienteID = 2, numeroGuia = 008, fechaEntrega = new DateTime(2026, 04, 12), importeImposicion = 0, importeEntrega = 5000, importeTransporte = 14000, importeTotal = 19000, proveedorTransporteId = 5, facturada = true, documentoId = 0},
                    new Guias {clienteID = 3, numeroGuia = 009, fechaEntrega = new DateTime(2026, 04, 13), importeImposicion = 5000, importeEntrega = 0, importeTransporte = 9000, importeTotal = 14000, proveedorTransporteId = 6, facturada = true, documentoId = 0},
                    new Guias {clienteID = 4, numeroGuia = 010, fechaEntrega = new DateTime(2026, 04, 14), importeImposicion = 0, importeEntrega = 0, importeTransporte = 7500, importeTotal = 7500, proveedorTransporteId = 2, facturada = true, documentoId = 0},
                    new Guias {clienteID = 1, numeroGuia = 011, fechaEntrega = new DateTime(2026, 04, 15), importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 20000, importeTotal = 35000, proveedorTransporteId = 1, facturada = true, documentoId = 0},
                    new Guias {clienteID = 2, numeroGuia = 012, fechaEntrega = new DateTime(2026, 04, 16), importeImposicion = 0, importeEntrega = 5000, importeTransporte = 15000, importeTotal = 20000, proveedorTransporteId = 1, facturada = true, documentoId = 0},
                    new Guias {clienteID = 3, numeroGuia = 013, fechaEntrega = new DateTime(2026, 04, 17), importeImposicion = 5000, importeEntrega = 0, importeTransporte = 10000, importeTotal = 15000, proveedorTransporteId = 1, facturada = true, documentoId = 0},
                    new Guias {clienteID = 4, numeroGuia = 014, fechaEntrega = new DateTime(2026, 04, 18), importeImposicion = 0, importeEntrega = 0, importeTransporte = 6000, importeTotal = 6000, proveedorTransporteId = 6, facturada = true, documentoId = 0},
                    new Guias {clienteID = 1, numeroGuia = 015, fechaEntrega = new DateTime(2026, 04, 19), importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 20000, importeTotal = 35000, proveedorTransporteId = 3, facturada = true, documentoId = 0},
                    new Guias {clienteID = 2, numeroGuia = 016, fechaEntrega = new DateTime(2026, 04, 20), importeImposicion = 0, importeEntrega = 5000, importeTransporte = 14000, importeTotal = 19000, proveedorTransporteId = 5, facturada = false, documentoId = 0},
                    new Guias {clienteID = 3, numeroGuia = 017, fechaEntrega = new DateTime(2026, 04, 21), importeImposicion = 5000, importeEntrega = 0, importeTransporte = 11000, importeTotal = 16000, proveedorTransporteId = 2, facturada = false, documentoId = 0},
                    new Guias {clienteID = 4, numeroGuia = 018, fechaEntrega = new DateTime(2026, 04, 22), importeImposicion = 0, importeEntrega = 5000, importeTransporte = 7000, importeTotal = 12000, proveedorTransporteId = 6, facturada = false, documentoId = 0},
                    new Guias {clienteID = 5, numeroGuia = 019, fechaEntrega = new DateTime(2026, 04, 23), importeImposicion = 5000, importeEntrega = 10000, importeTransporte = 19000, importeTotal = 34000, proveedorTransporteId = 5, facturada = false, documentoId = 0},
                    new Guias {clienteID = 1, numeroGuia = 020, fechaEntrega = new DateTime(2026, 04, 24), importeImposicion = 0, importeEntrega = 5000, importeTransporte = 15000, importeTotal = 20000, proveedorTransporteId = 3, facturada = false, documentoId = 0}
                };
            }
        }
        public List<ConvenioTransporte> LConvenioTransporte
        {
            get
            {
                return new List<ConvenioTransporte>
                {
                    new ConvenioTransporte { ConvenioId = 1, EmpresaTransporteId = 1, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(2026, 03, 31), ImporteConvenio = 150000 },
                    new ConvenioTransporte { ConvenioId = 2, EmpresaTransporteId = 2, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 100000 },
                    new ConvenioTransporte { ConvenioId = 3, EmpresaTransporteId = 3, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 120000 },
                    new ConvenioTransporte { ConvenioId = 4, EmpresaTransporteId = 4, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 90000 },
                    new ConvenioTransporte { ConvenioId = 5, EmpresaTransporteId = 5, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 110000 },
                    new ConvenioTransporte { ConvenioId = 6, EmpresaTransporteId = 6, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 80000 },
                    new ConvenioTransporte { ConvenioId = 7, EmpresaTransporteId = 7, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 130000 },
                    new ConvenioTransporte { ConvenioId = 8, EmpresaTransporteId = 8, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 140000 },
                    new ConvenioTransporte { ConvenioId = 9, EmpresaTransporteId = 9, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 160000 },
                    new ConvenioTransporte { ConvenioId = 10, EmpresaTransporteId = 10, FechaVigenciaDesde = new DateTime(2026, 01, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 170000 },
                    new ConvenioTransporte { ConvenioId = 11, EmpresaTransporteId = 1, FechaVigenciaDesde = new DateTime(2026, 04, 01), FechaVigenciaHasta = new DateTime(9999, 12, 31), ImporteConvenio = 180000 },
                };
            }
        }
        public int ConvenioVigenteId(int empresaTransporteId, DateTime fecha)
        {
        // Este método se encarga de verificar si existe un convenio vigente para el proveedor de transporte dado y la fecha actual.
        // Si existe un convenio vigente, devuelve su ID; de lo contrario, devuelve 0.

            foreach (var convenio in LConvenioTransporte)
            {
                if (convenio.EmpresaTransporteId == empresaTransporteId && convenio.FechaVigenciaDesde <= fecha && convenio.FechaVigenciaHasta >= fecha)
                {
                    return convenio.ConvenioId;
                }
            }
        return 0;
        }
        public decimal ConvenioVigenteImporte(int convenioId)
        {
            // Este método se encarga de devolver el importe del convenio vigente dado su ID.
            // Si el convenio no existe, devuelve 0.
            
            foreach (var convenio in LConvenioTransporte)
            {
                if (convenio.ConvenioId == convenioId)
                {
                    return convenio.ImporteConvenio;
                }
            }
            return 0;
        }
    }
}

