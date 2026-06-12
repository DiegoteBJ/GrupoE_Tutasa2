using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.FormularioPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GrupoE_Tutasa.RecepcionDespachoCDLargaDistancia
{
    internal class RecepcionDespachoCDLargaDistanciaModelo
    {
        public static int cdTrabajoId = Program.CDTrabajoId;

        public Dictionary<string, ServicioTransporte> _servicios;

        public RecepcionDespachoCDLargaDistanciaModelo()
        {
            _servicios = ServicioTransporteAlmacen.servicioTransportes
                .Where(s => s.CDOrigenId == cdTrabajoId || s.CDDestinoId == cdTrabajoId)
                .ToDictionary(
                    s => s.ServicioId.ToString(),
                    s => new ServicioTransporte
                    {
                        ServicioId = s.ServicioId.ToString(),
                        NombreEmpresa = ObtenerNombreEmpresa(s.EmpresaTransporteId),
                        FechaSalida = s.FechaYHoraSalida,
                        Ruta = ObtenerRuta(s.CDOrigenId, s.CDDestinoId),
                        HDRsARecibir = ObtenerHDRsARecibir(s.ServicioId),
                        HDRsADespachar = ObtenerHDRsADespachar(s.ServicioId)
                    });
        }

       

        public bool EsNroVacio(string nro)
            => string.IsNullOrWhiteSpace(nro);

        public bool TieneFormatoInvalido(string nro)
            => !Regex.IsMatch(nro, @"^\d+$");

        public bool ExisteServicio(string nro)
            => _servicios.ContainsKey (nro);

        public ServicioTransporte BuscarServicio(string nro)
        {
            _servicios.TryGetValue (nro, out var servicio);
            return servicio; 
        }
            
            

        public string GetNombreCDOperario()
            => ObtenerNombreCD(cdTrabajoId);

        // ===== HDRs a RECIBIR =====
        // HDRs de este servicio cuyo destino es MI CD (llegan aquí)
        private List<HDRTransporte> ObtenerHDRsARecibir(int servicioId)
        {
            return HDRTransporteAlmacen.hDRTransportes
                .Where(h => h.ServicioId == servicioId
                         && h.CDDestinoId == cdTrabajoId)
                .Select(h => new HDRTransporte
                {
                    HdrTransporteId = h.HdrTransporteId,
                    NroGuia = h.HdrTransporteId.ToString(),
                    Destino = ObtenerNombreCD(h.CDDestinoId),
                    Tamaño = $"{h.GuiaIds?.Count ?? 0} guías",
                    Estado = h.Estado.ToString()
                }).ToList();
        }

        // ===== HDRs a DESPACHAR =====
        // HDRs de este servicio cuyo origen es MI CD (salen de aquí)
        private List<HDRTransporte> ObtenerHDRsADespachar(int servicioId)
        {
            return HDRTransporteAlmacen.hDRTransportes
                .Where(h => h.ServicioId == servicioId
                         && h.CDOrigenId == cdTrabajoId)
                .Select(h => new HDRTransporte
                {
                    HdrTransporteId = h.HdrTransporteId,
                    NroGuia = h.HdrTransporteId.ToString(),
                    Destino = ObtenerNombreCD(h.CDDestinoId),
                    Tamaño = $"{h.GuiaIds?.Count ?? 0} guías",
                    Estado = h.Estado.ToString()
                }).ToList();
        }

        // ===== Cambiar estados al confirmar =====

        public void MarcarComoRecibidas(List<HDRTransporte> hdrs)
        {
            foreach (var hdr in hdrs)
            {
                var entidad = HDRTransporteAlmacen.hDRTransportes
                    .FirstOrDefault(h => h.HdrTransporteId == hdr.HdrTransporteId);
                if (entidad != null)
                    entidad.Estado = EstadoHDRTransporteEnum.RENDIDA;
            }
        }

        public void MarcarComoEnTransito(List<HDRTransporte> hdrs)
        {
            foreach (var hdr in hdrs)
            {
                var entidad = HDRTransporteAlmacen.hDRTransportes
                    .FirstOrDefault(h => h.HdrTransporteId == hdr.HdrTransporteId);
                if (entidad != null)
                    entidad.Estado = EstadoHDRTransporteEnum.EN_TRANSITO;
            }
        }

        // ===== HELPERS =====

        private string ObtenerNombreEmpresa(int empresaId)
        {
            var empresa = EmpresaTransporteAlmacen.empresaTransportes
                .FirstOrDefault(e => e.EmpresaTransporteId == empresaId);
            return empresa?.RazonSocial ?? "";
        }

        private string ObtenerNombreCD(int cdId)
        {
            var cd = CentroDistribucionAlmacen.centroDistribucions
                .FirstOrDefault(c => c.CdId == cdId);
            return cd?.Nombre ?? "";
        }

        private string ObtenerRuta(int cdOrigenId, int cdDestinoId)
        {
            return $"{ObtenerNombreCD(cdOrigenId)} - {ObtenerNombreCD(cdDestinoId)}";
        }
    }
}