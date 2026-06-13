using GrupoE_Tutasa.Almacenes;
using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.EstadoDeEncomienda
{
    internal class EstadoDeEncomiendaModelo
    {
        public Guia BuscarGuia(int guiaId)
        {
            var movimientosDeLaGuia = MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias
                .Where(m => m.GuiaId == guiaId)
                .OrderBy(m => m.FechaMovimiento)
                .Select(m => new MovimientoEstadoGuia
                {
                    GuiaId = m.GuiaId,
                    FechaMovimiento = m.FechaMovimiento,
                    Estado = m.Estado.ToString(),
                    Ubicacion = m.Ubicacion
                })
                .ToList();

            if (!movimientosDeLaGuia.Any())
                return null;

            return new Guia
            {
                GuiaId = guiaId,
                MovimientosEstado = movimientosDeLaGuia
            };
        }
    }
}
