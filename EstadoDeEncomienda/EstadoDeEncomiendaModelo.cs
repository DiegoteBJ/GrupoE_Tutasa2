using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.EstadoDeEncomienda
{
    internal class EstadoDeEncomiendaModelo
    {
        private List<Guia> guias = new List<Guia>
        {
            new Guia
            {
                GuiaId = 5001,
                MovimientosEstado = new List<MovimientoEstadoGuia>
                {
                    new MovimientoEstadoGuia
                    {
                        Fecha = DateTime.Today.AddDays(-3),
                        Estado = "ADMISION",
                        Ubicacion = "CD Buenos Aires"
                    },

                    new MovimientoEstadoGuia
                    {
                        Fecha = DateTime.Today.AddDays(-2),
                        Estado = "EN TRANSITO",
                        Ubicacion = "Ruta 9"
                    },

                    new MovimientoEstadoGuia
                    {
                        Fecha = DateTime.Today.AddDays(-1),
                        Estado = "PENDIENTE DE ENTREGA",
                        Ubicacion = "Agencia Moron"
                    }
                }
            },

            new Guia
            {
                GuiaId = 5002,
                MovimientosEstado = new List<MovimientoEstadoGuia>
                {
                    new MovimientoEstadoGuia
                    {
                        Fecha = DateTime.Today.AddDays(-5),
                        Estado = "ADMISION",
                        Ubicacion = "CD Rosario"
                    },

                    new MovimientoEstadoGuia
                    {
                        Fecha = DateTime.Today.AddDays(-4),
                        Estado = "ENTREGADA",
                        Ubicacion = "CD Rosario"
                    }
                }
            }
        };

        public Guia BuscarGuia(int guiaId)
        {
            return guias.FirstOrDefault(g => g.GuiaId == guiaId);
        }
    }
}