using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GrupoE_Tutasa.GenerarHDRTransporte
{
    internal class GenerarHDRTransporteModelo
    {
        public Dictionary<string, ServicioTransporte> _servicios =>
               ServicioTransporteAlmacen.servicioTransportes.ToDictionary(
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

        // ===== FILTRADO de guías pendientes por servicio =====
        // Condiciones:
        // 1. Estado de la guía debe ser ADMITIDA
        // 2. El CD actual debe ser distinto del CD destino
        private List<Guia> FiltrarGuiasParaServicio(ServicioTransporteEntidad servicio)
        {
            return GuiaAlmacen.guias
                .Where(g => g.Estado == EstadoGuiaEnum.ADMITIDA
                         && g.CDActualId != g.CDDestinoId)
                         //&& g.CDDestinoId == servicio.CDDestinoId)
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

        private string ObtenerRuta(int cdOrigenId, int cdDestinoId)
        {
            string origen = ObtenerNombreCD(cdOrigenId);
            string destino = ObtenerNombreCD(cdDestinoId);
            return $"{origen} - {destino}";
        }
    }
}