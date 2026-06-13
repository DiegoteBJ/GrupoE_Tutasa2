using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.FormularioPrincipal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.RecepcionDespachoAgencia
{
    internal class RecepcionDespachoAgenciaModelo
    {
        public Fletero? fleteroActual = null;
        public string Usuario = "Usuario 01";
        public int AgenciaTrabajo = Program.agenciaTrabajoId;

        public List<Fletero> LFleteros => FleteroAlmacen.fleteros
                .OrderBy(f => f.Apellido)
                .ThenBy(f => f.Nombre)
                .Select(f => new Fletero
                {
                    fleteroDNI = f.Dni,
                    fleteroNombre = f.Nombre,
                    fleteroApellido = f.Apellido
                })
                .ToList();

        public List<HDRRetiro> LHDRRetiro => HDRRetiroAlmacen.hDRRetiros
            .Where(h => h.Estado == EstadoHDRRetiroEnum.PENDIENTE)
                .OrderBy(h => h.FechaEmision)
                .Select(h =>
                {
                    var fletero = FleteroAlmacen.fleteros.FirstOrDefault(f => f.FleteroId == h.FleteroId);
                    return new HDRRetiro
                    {
                        numeroHDR = h.HdrRetiroId.ToString(),
                        fleteroDNI = fletero?.Dni ?? 0,
                        estadoHDR = h.Estado.ToString(),
                        GuiaIds = h.GuiaIds
                    };
                })
                .ToList();

        public List<HDRDistribucion> LHDRDistribucion => HDRDistribucionAlmacen.hDRDistribucions
            .Where(h => h.Estado == EstadoHDRDistribucionEnum.PENDIENTE)
                .OrderBy(h => h.FechaEmision)
                .Select(h =>
                {
                    var fletero = FleteroAlmacen.fleteros.FirstOrDefault(f => f.FleteroId == h.FleteroId);
                    return new HDRDistribucion
                    {
                        numeroHDR = h.HdrDistribucionId.ToString(),
                        fleteroDNI = fletero?.Dni ?? 0,
                        estadoHDR = h.Estado.ToString(),
                        GuiaIds = h.GuiaIds
                    };
                })
                .ToList();

        public List<Guia> ObtenerGuiasPorIds(List<int> ids) =>
            GuiaAlmacen.guias
                .Where(g => ids.Contains(g.GuiaId))
                .Select(g => new Guia
                {
                    guiaId = g.GuiaId,
                    tipo = g.TipoCaja.ToString(),
                    estado = g.Estado.ToString()
                })
                .ToList();

        public void ConfirmarRecepcion(string numeroHDR, List<int> guiaIdsConfirmadas)
        {
            foreach (int guiaId in guiaIdsConfirmadas)
            {
                var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.GuiaId == guiaId);
                if (guia != null)
                {
                    guia.Estado = EstadoGuiaEnum.PENDIENTE_DE_ENTREGA;

                    int nuevoMovimientoId = MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Count > 0
                        ? MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Max(m => m.MovimientoId) + 1
                        : 1;

                    MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(new MovimientoEstadoGuiaEntidad
                    {
                        MovimientoId = nuevoMovimientoId,
                        GuiaId = guiaId,
                        FechaMovimiento = DateTime.Now,
                        Estado = EstadoGuiaEnum.PENDIENTE_DE_ENTREGA,
                        Ubicacion = "Agencia: " + AgenciaTrabajo.ToString()
                    });
                }
            }

            if (int.TryParse(numeroHDR, out int hdrId))
            {
                var hdrRetiro = HDRRetiroAlmacen.hDRRetiros
                    .FirstOrDefault(h => h.HdrRetiroId == hdrId);

                if (hdrRetiro != null)
                {
                    hdrRetiro.Estado = EstadoHDRRetiroEnum.RENDIDA;
                    GuiaAlmacen.Guardar();
                    HDRRetiroAlmacen.Guardar();
                    MovimientoEstadoGuiaAlmacen.Guardar();
                    return;
                }

                var hdrDistribucion = HDRDistribucionAlmacen.hDRDistribucions
                    .FirstOrDefault(h => h.HdrDistribucionId == hdrId);

                if (hdrDistribucion != null)
                    hdrDistribucion.Estado = EstadoHDRDistribucionEnum.RENDIDA;
            }

            GuiaAlmacen.Guardar();
            HDRDistribucionAlmacen.Guardar();
            MovimientoEstadoGuiaAlmacen.Guardar();
        }
    }
}
