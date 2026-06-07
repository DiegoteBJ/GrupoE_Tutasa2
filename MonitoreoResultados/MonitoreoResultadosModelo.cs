using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.EmitirFactura;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.MonitoreoResultados
{
    internal class MonitoreoResultadosModelo
    {
        public List<ProveedoresLD> LProveedoresLD =>
        EmpresaTransporteAlmacen.empresaTransportes.Select(e => new ProveedoresLD
        {
            proveedorId = e.EmpresaTransporteId,
            proveedorName = e.RazonSocial,
            proveedorCUIT = e.Cuit
        }).ToList();
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
                    new Guias {clienteID = 1, numeroGuia = 001, fechaEntrega = new DateTime(2026, 04, 05), importeImposicion = 5000, importeEntrega = 5000, importeTransporte = 7000, importeTotal = 17000, proveedorTransporteId = 1, facturada = true, documentoId = 0 },
                    new Guias {clienteID = 2, numeroGuia = 002, fechaEntrega = new DateTime(2026, 04, 06), importeImposicion = 0, importeEntrega = 0, importeTransporte = 8500, importeTotal = 8500 , proveedorTransporteId = 2 , facturada = true, documentoId = 0},
                    new Guias {clienteID = 3, numeroGuia = 003, fechaEntrega = new DateTime(2026, 04, 07), importeImposicion = 0, importeEntrega = 0, importeTransporte = 6000, importeTotal = 6000 , proveedorTransporteId = 3 , facturada = true, documentoId = 0},
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
        public List<ConvenioTransporte> LConvenioTransporte =>
        ConveniosTransporteAlmacen.conveniosTransportes.Select(c => new ConvenioTransporte
        {
            ConvenioId = c.ConvenioId,
            EmpresaTransporteId = c.EmpresaTransporteId,
            FechaVigenciaDesde = c.FechaVigenciaDesde,
            FechaVigenciaHasta = c.FechaVigenciaHasta,
            ImporteConvenio = c.ImporteConvenio
        }).ToList();
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

