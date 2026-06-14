using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.FormularioPrincipal;

namespace GrupoE_Tutasa.GenerarHDRTransporte
{

    internal class GenerarHDRTransporteModelo
    {
        public int cdTrabajoId = Program.CDTrabajoId;
        
        public Dictionary<string, ServicioTransporte> _servicios =>
               ServicioTransporteAlmacen.servicioTransportes
            .Where(s=> s.CDOrigenId == cdTrabajoId)
            .ToDictionary(
                   s => s.ServicioId.ToString(),
                   s => new ServicioTransporte

                   {
                       ServicioId = s.ServicioId.ToString(),
                       NombreEmpresa = ObtenerNombreEmpresa(s.EmpresaTransporteId),
                       FechaEmision = s.FechaCreacion,
                       FechaHoraSalida = s.FechaYHoraSalida,
                       Ruta = ObtenerRuta(s.CDOrigenId, s.CDDestinoId),
   
                   GuiasPendientes = FiltrarGuiasParaServicio(s)
                   });

        // ===== VALIDACIONES =====

        public bool EsNroVacio(string nro)
            => string.IsNullOrWhiteSpace(nro);

        public bool TieneFormatoInvalido(string nro)
            => !Regex.IsMatch(nro, @"^\d+$");

        public bool ExisteServicio(string nro)
            => _servicios.ContainsKey(nro);

        public ServicioTransporte BuscarServicio(string nro)
        {
            _servicios.TryGetValue(nro, out var servicio);
            return servicio;
        }
        public string GetNombreCDOperario()
            => ObtenerNombreCD(cdTrabajoId);
        // ===== FILTRADO de guías pendientes por servicio =====
        // Condiciones:
        // 1. Estado de la guía debe ser ADMITIDA
        // 2. El CD actual debe ser distinto del CD destino
        private List<Guia> FiltrarGuiasParaServicio(ServicioTransporteEntidad servicio)
        {
            var guiasEnTransportePendiente = HDRTransporteAlmacen.hDRTransportes
                .Where(h => h.Estado == EstadoHDRTransporteEnum.PENDIENTE)
                .SelectMany(h => h.GuiaIds)
                .ToHashSet();

            return GuiaAlmacen.guias
                .Where(g => g.Estado == EstadoGuiaEnum.ADMITIDA
                         && g.CDActualId != g.CDDestinoId
                         && !guiasEnTransportePendiente.Contains(g.GuiaId))
                .Select(g => new Guia
                {
                    NroGuia = g.GuiaId.ToString(),
                    Tamaño = g.TipoCaja.ToString(),
                    Destino = ObtenerNombreCD(g.CDDestinoId)
                })
                .ToList();
        }

        // ===== HELPERS para obtener nombres =====

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

        public void GenerarHDR(string nroServicio, List<string> nrosGuia)
        {
            var servicioEntidad = ServicioTransporteAlmacen.servicioTransportes
                .FirstOrDefault(s => s.ServicioId.ToString() == nroServicio);

            var guiaIds = nrosGuia
                .Where(n => int.TryParse(n, out _))
                .Select(n => int.Parse(n))
                .ToList();

            int nuevoId = HDRTransporteAlmacen.hDRTransportes.Count > 0
                ? HDRTransporteAlmacen.hDRTransportes.Max(h => h.HdrTransporteId) + 1
                : 1;

            HDRTransporteAlmacen.hDRTransportes.Add(new HDRTransporteEntidad
            {
                HdrTransporteId = nuevoId,
                ServicioId = servicioEntidad?.ServicioId ?? 0,
                CDOrigenId = servicioEntidad?.CDOrigenId ?? 0,
                CDDestinoId = servicioEntidad?.CDDestinoId ?? 0,
                Estado = EstadoHDRTransporteEnum.PENDIENTE,
                FechaEmision = DateTime.Now,
                GuiaIds = guiaIds
            });

            foreach (var id in guiaIds)
            {
                var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.GuiaId == id);
                if (guia != null)
                {
                    if (guia.CDDestinoId == cdTrabajoId)
                        guia.Estado = EstadoGuiaEnum.TRASLADADA;
                    else
                        guia.Estado = EstadoGuiaEnum.ADMITIDA;
                    
                    guia.CDActualId = cdTrabajoId;
                    int nuevoMovimientoId = MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Count > 0
                        ? MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Max(m => m.MovimientoId) + 1
                        : 1;

                    MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(new MovimientoEstadoGuiaEntidad
                    {
                        MovimientoId = nuevoMovimientoId,
                        GuiaId = guia.GuiaId,
                        FechaMovimiento = DateTime.Now,
                        Estado = guia.Estado,
                        Ubicacion = "En CD: " + cdTrabajoId.ToString()
                    });
                }
            }

            int empresaTransporteId = servicioEntidad?.EmpresaTransporteId ?? 0;

            foreach (var id in guiaIds)
            {
                var cc = CuentaCorrienteClienteAlmacen.cuentaCorrienteClientes
                    .FirstOrDefault(c => c.GuiaId == id);
                if (cc != null)
                    cc.EmpresaTransporteId = empresaTransporteId;
            }

            HDRTransporteAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            MovimientoEstadoGuiaAlmacen.Guardar();
            CuentaCorrienteClienteAlmacen.Guardar();
        }

        private string ObtenerRuta(int cdOrigenId, int cdDestinoId)
        {
            string origen = ObtenerNombreCD(cdOrigenId);
            string destino = ObtenerNombreCD(cdDestinoId);
            return $"{origen} - {destino}";
        }
    }
}