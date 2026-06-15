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
        public  int cdTrabajoId = Program.CDTrabajoId;

        public Dictionary<string, ServicioTransporte> _servicios =>
            ServicioTransporteAlmacen.servicioTransportes
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
            var hdr = HDRTransporteAlmacen.hDRTransportes
                .FirstOrDefault(h => h.ServicioId == servicioId
                                  && h.CDDestinoId == cdTrabajoId
                                  && h.Estado == EstadoHDRTransporteEnum.EN_TRANSITO);

            if (hdr == null) return new List<HDRTransporte>();

            return hdr.GuiaIds.Select(guiaId =>
            {
                var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.GuiaId == guiaId);
                return new HDRTransporte
                {
                    HdrTransporteId = hdr.HdrTransporteId,
                    NroGuia = guiaId.ToString(),
                    Destino = ObtenerNombreCD(hdr.CDDestinoId),
                    Tamaño = guia?.TipoCaja.ToString() ?? "",
                    Estado = hdr.Estado.ToString()
                };
            }).ToList();
        }

        // ===== HDRs a DESPACHAR =====
        // HDRs de este servicio cuyo origen es MI CD (salen de aquí)
        private List<HDRTransporte> ObtenerHDRsADespachar(int servicioId)
        {
            var hdr = HDRTransporteAlmacen.hDRTransportes
                .FirstOrDefault(h => h.ServicioId == servicioId
                                  && h.CDOrigenId == cdTrabajoId
                                  && h.Estado == EstadoHDRTransporteEnum.PENDIENTE);

            if (hdr == null) return new List<HDRTransporte>();

            return hdr.GuiaIds.Select(guiaId =>
            {
                var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.GuiaId == guiaId);
                return new HDRTransporte
                {
                    HdrTransporteId = hdr.HdrTransporteId,
                    NroGuia = guiaId.ToString(),
                    Destino = ObtenerNombreCD(hdr.CDDestinoId),
                    Tamaño = guia?.TipoCaja.ToString() ?? "",
                    Estado = hdr.Estado.ToString()
                };
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
                {
                    entidad.Estado = EstadoHDRTransporteEnum.RENDIDA;

                    foreach (var guiaId in entidad.GuiaIds ?? new List<int>())
                    {
                        var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.GuiaId == guiaId);
                        if (guia != null)
                        {
                            guia.CDActualId = cdTrabajoId;
                            guia.Estado = guia.CDActualId == guia.CDDestinoId
                                ? EstadoGuiaEnum.EN_CD_DESTINO
                                : EstadoGuiaEnum.ADMITIDA;

                            int nuevoMovimientoId = MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Count > 0
                                ? MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Max(m => m.MovimientoId) + 1
                                : 1;

                            MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(new MovimientoEstadoGuiaEntidad
                            {
                                MovimientoId = nuevoMovimientoId,
                                GuiaId = guiaId,
                                FechaMovimiento = DateTime.Now,
                                Estado = guia.Estado,
                                Ubicacion = "En CD: " + cdTrabajoId.ToString()
                            });
                        }
                    }
                }
            }
            HDRTransporteAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            MovimientoEstadoGuiaAlmacen.Guardar();
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
            HDRTransporteAlmacen.Guardar();
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