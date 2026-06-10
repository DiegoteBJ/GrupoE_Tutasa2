using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GrupoE_Tutasa.EstadoDeEncomienda
{
    internal class EstadoDeEncomiendaModelo
    {
        private List<MovimientoEstadoGuia> movimientos = new List<MovimientoEstadoGuia>();

        public EstadoDeEncomiendaModelo()
        {
            CargarMovimientosDesdeJson();
        }

        private void CargarMovimientosDesdeJson()
        {
            string rutaArchivo = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos",
                "MovimientoEstadoGuiaEntidad.json"
            );

            if (!File.Exists(rutaArchivo))
            {
                movimientos = new List<MovimientoEstadoGuia>();
                return;
            }

            string json = File.ReadAllText(rutaArchivo);

            movimientos = JsonSerializer.Deserialize<List<MovimientoEstadoGuia>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            ) ?? new List<MovimientoEstadoGuia>();
        }

        public Guia BuscarGuia(int guiaId)
        {
            List<MovimientoEstadoGuia> movimientosDeLaGuia = movimientos
                .Where(m => m.GuiaId == guiaId)
                .OrderBy(m => m.FechaMovimiento)
                .ToList();

            if (!movimientosDeLaGuia.Any())
            {
                return null;
            }

            return new Guia
            {
                GuiaId = guiaId,
                MovimientosEstado = movimientosDeLaGuia
            };
        }
    }
}