using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GrupoE_Tutasa.GenerarHDRTransporte
{
    internal class GenerarHDRTransporteModelo
    {
        //CD del operario logueado
        public const int CDOperarioId = 1;
        // ===== MAPEO de almacenes a clases locales =====

        public List<ServicioTransporte> LServicios =>
            ServicioTransporteAlmacen.servicioTransportes
            
                 .Where(s => s.CDOrigenId == CDOperarioId)   // ← filtra por CD del operario
                 .Select(s => new ServicioTransporte
            {
                ServicioId = s.ServicioId.ToString(),
                FechaEmision = s.FechaCreacion,
                FechaHoraSalida = s.FechaYHoraSalida,
                NombreEmpresa = ObtenerNombreEmpresa(s.EmpresaTransporteId),
                Ruta = ObtenerRuta(s.CDOrigenId, s.CDDestinoId),
                GuiasPendientes = FiltrarGuiasParaServicio(s)
            }).ToList();

        // ===== VALIDACIONES =====

        public bool EsNroVacio(string nro)
            => string.IsNullOrWhiteSpace(nro);

        public bool TieneFormatoInvalido(string nro)
            => !Regex.IsMatch(nro, @"^\d+$");

        public bool ExisteServicio(string nro)
            => LServicios.Any(s => s.ServicioId == nro);

        public ServicioTransporte BuscarServicio(string nro)
            => LServicios.FirstOrDefault(s => s.ServicioId == nro);

        public string GetNombreCDOperario()
=> ObtenerNombreCD(CDOperarioId);

        // ===== FILTRADO de guías pendientes por servicio =====
        // Condiciones:
        // 1. Estado de la guía debe ser ADMITIDA
        // 2. El CD actual debe ser distinto del CD destino
        // 3. El CD destino de la guía debe coincidir con el CD destino del servicio
        private List<Guia> FiltrarGuiasParaServicio(ServicioTransporteEntidad servicio)
        {
            return GuiaAlmacen.guias
                .Where(g => g.Estado == EstadoGuiaEnum.ADMITIDA
                         && g.CDActualId == g.CDDestinoId
                         && g.CDDestinoId == servicio.CDDestinoId)
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