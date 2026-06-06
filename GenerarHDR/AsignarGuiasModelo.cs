using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class AsignarGuiasModelo
    {

        public List<Guias> LGuiasAAsignar { get; set; } = new List<Guias>()

                {
                    new Guias
                    {
                        GuiaId = 1,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle Falsa",
                            Numero = "123",
                            CodigoPostal = "C1000",
                            Localidad = "Buenos Aires",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "L",
                        EstadoGuia = "A retirar",
                        NombreDestinatarioGuia = "Juan Pérez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Calle Verdadera",
                            Numero = "456",
                            CodigoPostal = "2000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 2,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle Falsa",
                            Numero = "123",
                            CodigoPostal = "C1000",
                            Localidad = "Buenos Aires",
                            Provincia = "Buenos Aires"

                        },
                        tamañoGuia = "M",
                        EstadoGuia = "A retirar",
                        NombreDestinatarioGuia = "María Gómez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "789",
                            CodigoPostal = "2000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 3,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Boulevard de los Sueños Rotos",
                            Numero = "789",
                            CodigoPostal = "3000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "S",
                        EstadoGuia = "A retirar",
                        NombreDestinatarioGuia = "Carlos Rodríguez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Boulevard Real",
                            Numero = "321",
                            CodigoPostal = "7700",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 4,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle del Olvido",
                            Numero = "321",
                            CodigoPostal = "4000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "XL",
                        EstadoGuia = "A retirar",
                        NombreDestinatarioGuia = "Ana Martínez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Calle Real",
                            Numero = "654",
                            CodigoPostal = "2000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 5,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Avenida de la Esperanza",
                            Numero = "654",
                            CodigoPostal = "5000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "M",
                        EstadoGuia = "Admitida",
                        NombreDestinatarioGuia = "Luis Fernández",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "987",
                            CodigoPostal = "C1001",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 6,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle de la Fortuna",
                            Numero = "987",
                            CodigoPostal = "6000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "S",
                        EstadoGuia = "Admitida",
                        NombreDestinatarioGuia = "Sofía López",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Calle Real",
                            Numero = "987",
                            CodigoPostal = "C1003",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 7,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Avenida del Destino",
                            Numero = "159",
                            CodigoPostal = "7000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "XL",
                        EstadoGuia = "Admitida",
                        NombreDestinatarioGuia = "Miguel Sánchez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "159",
                            CodigoPostal = "C1000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 8,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle de la Ilusión",
                            Numero = "753",
                            CodigoPostal = "8000",
                            Localidad = "Buenos Aires",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "L",
                        EstadoGuia = "Admitida",
                        NombreDestinatarioGuia = "Laura Gómez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "852",
                            CodigoPostal = "C1000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 9,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Avenida de la Libertad",
                            Numero = "852",
                            CodigoPostal = "9000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "M",
                        EstadoGuia = "En distribución",
                        NombreDestinatarioGuia = "Jorge Rodríguez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "852",
                            CodigoPostal = "C1000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 2
                    },
                    new Guias
                    {
                        GuiaId = 10,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle Falsa",
                            Numero = "123",
                            CodigoPostal = "1000",
                            Localidad = "Buenos Aires",
                            Provincia = "Buenos Aires"

                        },
                        tamañoGuia = "M",
                        EstadoGuia = "Impuesta Telefónicamente",
                        NombreDestinatarioGuia = "María Gómez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "7819",
                            CodigoPostal = "C1000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                };

        public List<Fleteros> LFleteros { get; set; } = new List<Fleteros>()

                {
                    new Fleteros { FleteroId = 1, FleteroDNI = "12345678", FleteroNombre = "Jorge", FleteroApellido = "Perez", CPCobertura = new List<string> { "C1000", "C1001", "C1002" } },
                    new Fleteros { FleteroId = 2, FleteroDNI = "23456789", FleteroNombre = "Gaston", FleteroApellido = "Gonzales", CPCobertura = new List<string> { "C2000", "C2001", "C2002", "C2003" } },
                    new Fleteros { FleteroId = 3, FleteroDNI = "33333333", FleteroNombre = "Pedro", FleteroApellido = "Rodriguez", CPCobertura = new List<string> { "C3000", "C3001", "C3002" } },
                    new Fleteros { FleteroId = 4, FleteroDNI = "7777777", FleteroNombre = "Julio", FleteroApellido = "Contreras", CPCobertura = new List<string> { "C4000", "C4001", "C4002" } },
                };

        // Listas HDR generadas
        public List<HDRRetiro> HDRsRetiro { get; set; } = new List<HDRRetiro>()
        {
            new HDRRetiro
            {
                HDRRetiroId = 1,
             
                fleteroId = 1,
                FechaEmision = DateTime.Now.AddDays(-1),
                FechaRendicion = DateTime.MinValue, // aún no rendida
                Estado = "Pendiente",
                GuiasIds = new List<int> { 0, 0 } // varias guías al mismo domicilio
            },
            new HDRRetiro
            {
                HDRRetiroId = 2,
               
                fleteroId = 2,
                FechaEmision = DateTime.Now.AddDays(-2),
                FechaRendicion = DateTime.MinValue,
                Estado = "Pendiente",
                GuiasIds = new List<int> { 0, 0 } // varias guías al mismo domicilio
            }
        };

        public List<HDRDistribucion> HDRsDistribucion { get; set; } = new List<HDRDistribucion>()
        {
            new HDRDistribucion
            {
                HDRDistribucionId = 1,
               
                fleteroId = 1,
                FechaEmision = DateTime.Now.AddDays(-1),
                FechaRendicion = DateTime.MinValue, // aún no rendida
                Estado = "Pendiente",
                GuiasIds = new List<int> { 0, 0 } // varias guías al mismo domicilio
            },
            new HDRDistribucion
            {
                HDRDistribucionId = 2,
               
                fleteroId = 2,
                FechaEmision = DateTime.Now.AddDays(-2),
                FechaRendicion = DateTime.MinValue,
                Estado = "Pendiente",
                GuiasIds = new List<int> { 0, 0 } // varias guías al mismo domicilio
            },


        };

            // Estado interno del modelo
            private HashSet<int> guiasAsignadas = new HashSet<int>();
            private int ultimoHDRRetiroId = 0;
            private int ultimoHDRDistribucionId = 0;

            public static bool ValidarDniString(string dni)
            {
              if (string.IsNullOrWhiteSpace(dni)) return false;
              // Sólo dígitos ya garantizados por TextChanged, pero volvemos a intentar parsear
              if (!int.TryParse(dni, out int numero)) return false;
              if (numero < 0) return false;
              return dni.Length == 7 || dni.Length == 8;
            }

        // ✅ Validación de código postal
        // ✅ Validar formato de CP Argentino (Letra + 4 dígitos)
        public bool ValidarCodigoPostalArg(string cp)
        {
            if (string.IsNullOrWhiteSpace(cp)) return false;
            var regex = new Regex(@"^[A-Z][0-9]{4}$");
            return regex.IsMatch(cp.Trim().ToUpper());
        }

        // ✅ Filtrar y reordenar guías por CP
        public (List<ListViewItem> coincidencias, List<ListViewItem> noCoincidencias) FiltrarPorCodigoPostal(
            string cp, ListView seleccion, bool esRetiro)
        {
            var coincidencias = new List<ListViewItem>();
            var noCoincidencias = new List<ListViewItem>();

            foreach (ListViewItem item in seleccion.Items)
            {
                var guia = item.Tag as Guias;
                if (guia == null) continue;

                string cpComparar = esRetiro ? guia.DomicilioRetiro.CodigoPostal
                                             : guia.DomicilioEntrega.CodigoPostal;

                if (cpComparar == cp)
                {
                    item.BackColor = Color.LightGreen;
                    coincidencias.Add(item);
                }
                else
                {
                    item.BackColor = Color.LightGray;
                    noCoincidencias.Add(item);
                }
            }

            return (coincidencias, noCoincidencias);
        }

        // ✅ Resetear colores y reordenar por GuíaId
        public List<ListViewItem> ResetearYOrdenar(ListView seleccion)
        {
            foreach (ListViewItem item in seleccion.Items)
                item.BackColor = Color.White;

            return seleccion.Items
                .Cast<ListViewItem>()
                .OrderBy(i =>
                {
                    int guiaId;
                    return int.TryParse(i.Text, out guiaId) ? guiaId : int.MaxValue;
                })
                .ToList();
        }

        // ✅ Buscar fletero
        public Fleteros BuscarFleteroPorDni(string dni)
        {
            return LFleteros.FirstOrDefault(f => f.FleteroDNI == dni);
        }

        // ✅ Obtener guías según estado
        public IEnumerable<Guias> ObtenerGuiasPorEstado(string estado, Fleteros fletero, HashSet<int> guiasEnDetalle)
        {
            if (fletero == null) return Enumerable.Empty<Guias>();

            if (estado == "A retirar")
            {
                return LGuiasAAsignar.Where(g =>
                    g.EstadoGuia == "A retirar" &&
                    fletero.CPCobertura.Contains(g.DomicilioRetiro.CodigoPostal) &&
                    !guiasAsignadas.Contains(g.GuiaId) &&
                    !guiasEnDetalle.Contains(g.GuiaId) &&
                    !HDRsRetiro.Any(h => h.GuiasIds.Contains(g.GuiaId) && h.Estado == "Pendiente"));
            }
            else if (estado == "Distribución")
            {
                return LGuiasAAsignar.Where(g =>
                    (g.EstadoGuia == "Admitida" ||
                     (g.EstadoGuia == "En distribución" && g.IntentosDeEntrega < 2)) &&
                    fletero.CPCobertura.Contains(g.DomicilioEntrega.CodigoPostal) &&
                    !guiasAsignadas.Contains(g.GuiaId) &&
                    !guiasEnDetalle.Contains(g.GuiaId) &&
                    !HDRsDistribucion.Any(h => h.GuiasIds.Contains(g.GuiaId) && h.Estado == "Pendiente"));
            }

            return Enumerable.Empty<Guias>();
        }

        // ✅ Marcar y desmarcar guías
        public void AsignarGuia(int guiaId) => guiasAsignadas.Add(guiaId);
        public void DesasignarGuia(int guiaId) => guiasAsignadas.Remove(guiaId);

        // ✅ Generar HDRs provisorios
        public List<HDRResumen> GenerarHDR(List<Guias> guiasSeleccionadas)
        {
            var hdrsProvisorios = new List<HDRResumen>();
            int idRetiroTemp = HDRsRetiro.Any() ? HDRsRetiro.Max(h => h.HDRRetiroId) + 1 : 1;
            int idDistribTemp = HDRsDistribucion.Any() ? HDRsDistribucion.Max(h => h.HDRDistribucionId) + 1 : 1;

            var grupos = guiasSeleccionadas.GroupBy(g =>
                (g.EstadoGuia == "A retirar")
                    ? $"{g.DomicilioRetiro.Calle}-{g.DomicilioRetiro.Numero}-{g.DomicilioRetiro.CodigoPostal}"
                    : $"{g.DomicilioEntrega.Calle}-{g.DomicilioEntrega.Numero}-{g.DomicilioEntrega.CodigoPostal}");

            foreach (var grupo in grupos)
            {
                var guiasGrupo = grupo.ToList();

                if (guiasGrupo.All(g => g.EstadoGuia == "A retirar"))
                {
                    hdrsProvisorios.Add(new HDRResumen(idRetiroTemp++, guiasGrupo, "Retiro"));
                }
                else
                {
                    hdrsProvisorios.Add(new HDRResumen(idDistribTemp++, guiasGrupo, "Distribución"));
                }
            }

            return hdrsProvisorios.OrderBy(r => r.Domicilio).ToList();
        }

        // ✅ Imprimir y guardar HDRs
        public void ImprimirResumen(List<HDRResumen> resumen, Fleteros fletero, int totalHDR)
        {
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            MessageBox.Show($"Se imprimieron {totalHDR} HDR y el Resumen HDR\nFecha/Hora: {fechaHora}",
                "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ultimoHDRRetiroId = HDRsRetiro.Any() ? HDRsRetiro.Max(h => h.HDRRetiroId) : ultimoHDRRetiroId;
            ultimoHDRDistribucionId = HDRsDistribucion.Any() ? HDRsDistribucion.Max(h => h.HDRDistribucionId) : ultimoHDRDistribucionId;

            foreach (var r in resumen)
            {
                var guiasGrupo = LGuiasAAsignar.Where(g => r.GuiasIds.Contains(g.GuiaId)).ToList();
                if (!guiasGrupo.Any()) continue;

                if (r.TipoHDR == "Retiro")
                {
                    ultimoHDRRetiroId++;
                    HDRsRetiro.Add(new HDRRetiro
                    {
                        HDRRetiroId = ultimoHDRRetiroId,
                        fleteroId = fletero.FleteroId,
                        FechaEmision = DateTime.Now,
                        Estado = "Pendiente",
                        GuiasIds = guiasGrupo.Select(g => g.GuiaId).ToList()
                    });
                }
                else
                {
                    ultimoHDRDistribucionId++;
                    HDRsDistribucion.Add(new HDRDistribucion
                    {
                        HDRDistribucionId = ultimoHDRDistribucionId,
                        fleteroId = fletero.FleteroId,
                        FechaEmision = DateTime.Now,
                        Estado = "Pendiente",
                        GuiasIds = guiasGrupo.Select(g => g.GuiaId).ToList()
                    });

                    foreach (var g in guiasGrupo.Where(g => g.EstadoGuia == "Admitida"))
                    {
                        g.EstadoGuia = "En distribución";
                    }
                }
            }

            // En modo mock no hay persistencia real, pero acá podrías simular un "GuardarCambios"
            // TODO: cuando conectes JSON, reemplazar por:
            // GuiaAlmacen.Guardar();
            // HDRRetiroAlmacen.Guardar();
            // HDRDistribucionAlmacen.Guardar();
            // FleteroAlmacen.Guardar();

            // Ahora
            //public List<Guias> LGuiasAAsignar { get; set; } = new List<Guias>() { ... };
            // Luego
            //public List<GuiaEntidad> LGuiasAAsignar => GuiaAlmacen.guias;

            
        }




    }
}
