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
        public List<Guias> LGuias =>
        CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes
            .Where(cc => cc.Facturado
                      && cc.FechaEntrega != DateTime.MaxValue
                      && cc.DocumentoId != 0
                      && cc.EmpresaTransporteId != 0)
            .Select(cc => new Guias
            {
                clienteID = cc.ClienteId,
                numeroGuia = cc.GuiaId,
                fechaEntrega = cc.FechaEntrega,
                importeImposicion = cc.PrecioImposicion,
                importeEntrega = cc.PrecioEntrega,
                importeTransporte = cc.PrecioTransporte,
                importeTotal = cc.PrecioCalculadoTotal,
                proveedorTransporteId = cc.EmpresaTransporteId,
                facturada = cc.Facturado,
                documentoId = cc.DocumentoId
            }).ToList();
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

