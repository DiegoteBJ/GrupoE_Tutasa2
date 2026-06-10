using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class AsignarGuiasModelo
    {
        public List<GuiaEntidad> LGuiasAAsignar => GuiaAlmacen.guias;
        public List<FleteroEntidad> LFleteros => FleteroAlmacen.fleteros;
        public List<HDRRetiroEntidad> HDRsRetiro => HDRRetiroAlmacen.hDRRetiros;
        public List<HDRDistribucionEntidad> HDRsDistribucion => HDRDistribucionAlmacen.hDRDistribucions;



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
        public FleteroEntidad BuscarFleteroPorDni(string dni)
        {
            return LFleteros.FirstOrDefault(f => f.Dni.ToString() == dni);
        }

        // ✅ Obtener guías según estado
        public IEnumerable<GuiaEntidad> ObtenerGuiasPorEstado(string estado, FleteroEntidad fletero, HashSet<int> guiasEnDetalle)
        {
            if (fletero == null) return Enumerable.Empty<GuiaEntidad>();

            if (estado == "A_RETIRAR")
            {
                return LGuiasAAsignar.Where(g =>
                    g.Estado == EstadoGuiaEnum.A_RETIRAR &&
                    g.DomicilioRetiro != null &&
                    fletero.CodigosPostalesCobertura.Contains(g.DomicilioRetiro.CodigoPostal) &&
                    !guiasAsignadas.Contains(g.GuiaId) &&
                    !guiasEnDetalle.Contains(g.GuiaId) &&
                    !HDRsRetiro.Any(h => h.GuiaIds.Contains(g.GuiaId) && h.Estado == EstadoHDRRetiroEnum.PENDIENTE));
            }
            else if (estado == "EN_DISTRIBUCION")
            {
                return LGuiasAAsignar.Where(g =>
                    (g.Estado == EstadoGuiaEnum.ADMITIDA ||
                    (g.Estado == EstadoGuiaEnum.EN_CD_DESTINO) ||
                    (g.Estado == EstadoGuiaEnum.EN_DISTRIBUCION && g.IntentosDeEntrega < 2)) &&
                    g.DomicilioEntrega != null &&
                    fletero.CodigosPostalesCobertura.Contains(g.DomicilioEntrega.CodigoPostal) &&
                    !guiasAsignadas.Contains(g.GuiaId) &&
                    !guiasEnDetalle.Contains(g.GuiaId) &&
                    !HDRsDistribucion.Any(h => h.GuiaIds.Contains(g.GuiaId) && h.Estado == EstadoHDRDistribucionEnum.PENDIENTE));
            }

            return Enumerable.Empty<GuiaEntidad>();
        }

        // ✅ Marcar y desmarcar guías
        public void AsignarGuia(int guiaId) => guiasAsignadas.Add(guiaId);
        public void DesasignarGuia(int guiaId) => guiasAsignadas.Remove(guiaId);

        // ✅ Generar HDRs provisorios
        public List<HDRResumen> GenerarHDR(List<GuiaEntidad> guiasSeleccionadas)
        {
            var hdrsProvisorios = new List<HDRResumen>();
            int idRetiroTemp = HDRsRetiro.Any() ? HDRsRetiro.Max(h => h.HdrRetiroId) + 1 : 1;
            int idDistribTemp = HDRsDistribucion.Any() ? HDRsDistribucion.Max(h => h.HdrDistribucionId) + 1 : 1;

            var grupos = guiasSeleccionadas.GroupBy(g =>
                (g.Estado == EstadoGuiaEnum.A_RETIRAR)
                    ? $"{g.DomicilioRetiro.Calle}-{g.DomicilioRetiro.Numero}-{g.DomicilioRetiro.Piso}-{g.DomicilioRetiro.Depto}-{g.DomicilioRetiro.CodigoPostal}"
                    : $"{g.DomicilioEntrega.Calle}-{g.DomicilioEntrega.Numero}-{g.DomicilioEntrega.Piso}-{g.DomicilioEntrega.Depto}-{g.DomicilioEntrega.CodigoPostal}");

            foreach (var grupo in grupos)
            {
                var guiasGrupo = grupo.ToList();
                var g = guiasGrupo.First(); // tomamos la primera guía del grupo para armar domicilio

                if (guiasGrupo.All(x => x.Estado == EstadoGuiaEnum.A_RETIRAR))
                {
                    var domicilio = $"{g.DomicilioRetiro.Calle} {g.DomicilioRetiro.Numero} - Piso: {g.DomicilioRetiro.Piso} - Depto: {g.DomicilioRetiro.Depto}";
                    hdrsProvisorios.Add(new HDRResumen(idRetiroTemp++, guiasGrupo, "Retiro")
                    {
                        Domicilio = domicilio,
                        CodigoPostal = g.DomicilioRetiro.CodigoPostal
                    });
                }
                else
                {
                    var domicilio = $"{g.DomicilioEntrega.Calle} {g.DomicilioEntrega.Numero} - Piso: {g.DomicilioEntrega.Piso} - Depto: {g.DomicilioEntrega.Depto}";
                    hdrsProvisorios.Add(new HDRResumen(idDistribTemp++, guiasGrupo, "Distribución")
                    {
                        Domicilio = domicilio,
                        CodigoPostal = g.DomicilioEntrega.CodigoPostal
                    });
                }
            }

            return hdrsProvisorios.OrderBy(r => r.Domicilio).ToList();
        }

        // ✅ Imprimir y guardar HDRs
        public void ImprimirResumen(List<HDRResumen> resumen, FleteroEntidad fletero, int totalHDR)
        {
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            MessageBox.Show($"Se imprimieron {totalHDR} HDR y el Resumen HDR\nFecha/Hora: {fechaHora}",
                "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ultimoHDRRetiroId = HDRsRetiro.Any() ? HDRsRetiro.Max(h => h.HdrRetiroId) : ultimoHDRRetiroId;
            ultimoHDRDistribucionId = HDRsDistribucion.Any() ? HDRsDistribucion.Max(h => h.HdrDistribucionId) : ultimoHDRDistribucionId;

            foreach (var r in resumen)
            {
                var guiasGrupo = LGuiasAAsignar.Where(g => r.GuiasIds.Contains(g.GuiaId)).ToList();
                if (!guiasGrupo.Any()) continue;

                if (r.TipoHDR == "Retiro")
                {
                    ultimoHDRRetiroId++;
                    HDRsRetiro.Add(new HDRRetiroEntidad
                    
                    {
                        HdrRetiroId = ultimoHDRRetiroId,
                        FleteroId = fletero.FleteroId,
                        FechaEmision = DateTime.Today,
                        Estado = EstadoHDRRetiroEnum.PENDIENTE,
                        GuiaIds = guiasGrupo.Select(g => g.GuiaId).ToList()
                    });
                }
                else
                {
                    ultimoHDRDistribucionId++;
                    HDRsDistribucion.Add(new HDRDistribucionEntidad                    
                    {
                        HdrDistribucionId = ultimoHDRDistribucionId,
                        FleteroId = fletero.FleteroId,
                        FechaEmision = DateTime.Today,
                        Estado = EstadoHDRDistribucionEnum.PENDIENTE,
                        GuiaIds = guiasGrupo.Select(g => g.GuiaId).ToList()
                    });

                    foreach (var g in guiasGrupo.Where(g => g.Estado == EstadoGuiaEnum.ADMITIDA || g.Estado == EstadoGuiaEnum.EN_CD_DESTINO))
                    {
                        g.Estado = EstadoGuiaEnum.EN_DISTRIBUCION;
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

            GuiaAlmacen.Guardar();
            HDRRetiroAlmacen.Guardar();
            HDRDistribucionAlmacen.Guardar();
            FleteroAlmacen.Guardar();
            ClienteAlmacen.Guardar();
        }




    }
}
