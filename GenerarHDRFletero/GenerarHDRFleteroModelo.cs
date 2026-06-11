using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class GenerarHDRFleteroModelo
    {
        public List<Guias> LGuiasAAsignar => GuiaAlmacen.guias
    .Select(g => new Guias
    {
        GuiaId = g.GuiaId,
        ModalidadImposicion = (ModalidadImposicionEnum)g.ModalidadImposicion,
        DomicilioRetiro = g.DomicilioRetiro == null ? null : new Domicilio
        {
            Calle = g.DomicilioRetiro.Calle,
            Numero = g.DomicilioRetiro.Numero,
            Piso = g.DomicilioRetiro.Piso,
            Depto = g.DomicilioRetiro.Depto,
            CodigoPostal = g.DomicilioRetiro.CodigoPostal,
            Localidad = g.DomicilioRetiro.LocalidadId.ToString(),
        },
        ModalidadEntrega = (ModalidadEntregaEnum)g.ModalidadEntrega,
        NombreDestinatarioGuia = g.NombreDestinatario,
        ApellidoDestinatarioGuia = g.ApellidoDestinatario,
        tamañoGuia = (TipoCajaEnum)g.TipoCaja,
        DomicilioEntrega = g.DomicilioEntrega == null ? null : new Domicilio
        {
            Calle = g.DomicilioEntrega.Calle,
            Numero = g.DomicilioEntrega.Numero,
            Piso = g.DomicilioEntrega.Piso,
            Depto = g.DomicilioEntrega.Depto,
            CodigoPostal = g.DomicilioEntrega.CodigoPostal,
            Localidad = g.DomicilioEntrega.LocalidadId.ToString(),
        },
        IntentosDeEntrega = g.IntentosDeEntrega,
        CDActualId = g.CDActualId,
        EstadoGuia = (EstadoGuiaEnum)g.Estado,
    })
    .ToList();


        public List<Fleteros> LFleteros => FleteroAlmacen.fleteros
        .Select(f => new Fleteros
        {
            FleteroId = f.FleteroId,
            FleteroNombre = f.Nombre,
            FleteroApellido = f.Apellido,
            FleteroDNI = f.Dni,
            CPCobertura = f.CodigosPostalesCobertura
        })
        .ToList();


        public List<HDRRetiro> HDRsRetiro => HDRRetiroAlmacen.hDRRetiros
        .Select(h => new HDRRetiro
        {
            HDRRetiroId = h.HdrRetiroId,
            fleteroId = h.FleteroId,
            Estado = (EstadoHDRRetiroEnum)h.Estado,
            FechaEmision = h.FechaEmision,
            FechaRendicion = h.FechaRendicion,
            GuiaIds = h.GuiaIds
        })
        .ToList();
        public List<HDRDistribucion> HDRsDistribucion => HDRDistribucionAlmacen.hDRDistribucions
        .Select(h => new HDRDistribucion
        {
            HDRDistribucionId = h.HdrDistribucionId,
            fleteroId = h.FleteroId,
            Estado = (EstadoHDRDistribucionEnum)h.Estado,
            FechaEmision = h.FechaEmision,
            FechaRendicion = h.FechaRendicion,
            GuiaIds = h.GuiaIds
        })
        .ToList();

        private HashSet<int> guiasAsignadas = new HashSet<int>();
            private int ultimoHDRRetiroId = 0;
            private int ultimoHDRDistribucionId = 0;

            public static bool ValidarDniString(string dni)
            {
              if (string.IsNullOrWhiteSpace(dni)) return false;
              if (!int.TryParse(dni, out int numero)) return false;
              if (numero < 0) return false;
              return dni.Length == 7 || dni.Length == 8;
            }

        public bool ValidarCodigoPostalArg(string cp)
        {
            if (string.IsNullOrWhiteSpace(cp)) return false;
            var regex = new Regex(@"^[A-Z][0-9]{4}$");
            return regex.IsMatch(cp.Trim().ToUpper());
        }

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

        public Fleteros BuscarFleteroPorDni(string dni)
        {
            return LFleteros.FirstOrDefault(f => f.FleteroDNI.ToString() == dni);
        }

        public IEnumerable<Guias> ObtenerGuiasPorEstado(string estado, Fleteros fletero, HashSet<int> guiasEnDetalle)
        {
            if (fletero == null) return Enumerable.Empty<Guias>();

            if (estado == "A_RETIRAR")
            {
                return LGuiasAAsignar.Where(g =>
                    g.EstadoGuia == EstadoGuiaEnum.A_RETIRAR &&
                    g.DomicilioRetiro != null &&
                    fletero.CPCobertura.Contains(g.DomicilioRetiro.CodigoPostal) &&
                    !guiasAsignadas.Contains(g.GuiaId) &&
                    !guiasEnDetalle.Contains(g.GuiaId) &&
                    !HDRsRetiro.Any(h => h.GuiaIds.Contains(g.GuiaId) && h.Estado == EstadoHDRRetiroEnum.PENDIENTE));
            }
            else if (estado == "EN_DISTRIBUCION")
            {
                return LGuiasAAsignar.Where(g =>
                    (g.EstadoGuia == EstadoGuiaEnum.ADMITIDA ||
                    (g.EstadoGuia == EstadoGuiaEnum.EN_CD_DESTINO) ||
                    (g.EstadoGuia == EstadoGuiaEnum.EN_DISTRIBUCION && g.IntentosDeEntrega < 2)) &&
                    g.DomicilioEntrega != null &&
                    fletero.CPCobertura.Contains(g.DomicilioEntrega.CodigoPostal) &&
                    !guiasAsignadas.Contains(g.GuiaId) &&
                    !guiasEnDetalle.Contains(g.GuiaId) &&
                    !HDRsDistribucion.Any(h => h.GuiaIds.Contains(g.GuiaId) && h.Estado == EstadoHDRDistribucionEnum.PENDIENTE));
            }
            return Enumerable.Empty<Guias>();
        }

        public void AsignarGuia(int guiaId) => guiasAsignadas.Add(guiaId);
        public void DesasignarGuia(int guiaId) => guiasAsignadas.Remove(guiaId);

        public List<HDRResumen> GenerarHDR(List<Guias> guiasSeleccionadas)
        {
            var hdrsProvisorios = new List<HDRResumen>();
            int idRetiroTemp = HDRsRetiro.Any() ? HDRsRetiro.Max(h => h.HDRRetiroId) + 1 : 1;
            int idDistribTemp = HDRsDistribucion.Any() ? HDRsDistribucion.Max(h => h.HDRDistribucionId) + 1 : 1;

            var grupos = guiasSeleccionadas.GroupBy(g =>
                (g.EstadoGuia == EstadoGuiaEnum.A_RETIRAR)
                    ? $"{g.DomicilioRetiro.Calle}-{g.DomicilioRetiro.Numero}-{g.DomicilioRetiro.Piso}-{g.DomicilioRetiro.Depto}-{g.DomicilioRetiro.CodigoPostal}"
                    : $"{g.DomicilioEntrega.Calle}-{g.DomicilioEntrega.Numero}-{g.DomicilioEntrega.Piso}-{g.DomicilioEntrega.Depto}-{g.DomicilioEntrega.CodigoPostal}");

            foreach (var grupo in grupos)
            {
                var guiasGrupo = grupo.ToList();
                var g = guiasGrupo.First();

                if (guiasGrupo.All(x => x.EstadoGuia == EstadoGuiaEnum.A_RETIRAR))
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

        public void ImprimirResumen(List<HDRResumen> resumen, Fleteros fletero, int totalHDR)
        {
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            MessageBox.Show($"Se imprimieron {totalHDR} HDR y el Resumen HDR\nFecha/Hora: {fechaHora}",
                "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ inicializar últimos IDs desde almacenes
            ultimoHDRRetiroId = HDRRetiroAlmacen.hDRRetiros.Any()
                ? HDRRetiroAlmacen.hDRRetiros.Max(h => h.HdrRetiroId)
                : ultimoHDRRetiroId;

            ultimoHDRDistribucionId = HDRDistribucionAlmacen.hDRDistribucions.Any()
                ? HDRDistribucionAlmacen.hDRDistribucions.Max(h => h.HdrDistribucionId)
                : ultimoHDRDistribucionId;

            foreach (var r in resumen)
            {
                var guiasGrupo = LGuiasAAsignar.Where(g => r.GuiasIds.Contains(g.GuiaId)).ToList();
                if (!guiasGrupo.Any()) continue;

                if (r.TipoHDR == "Retiro")
                {
                    ultimoHDRRetiroId++;

                    // ✅ agregar entidad directamente al almacén con conversión explícita de enum
                    HDRRetiroAlmacen.hDRRetiros.Add(new HDRRetiroEntidad
                    {
                        HdrRetiroId = ultimoHDRRetiroId,
                        FleteroId = fletero.FleteroId,
                        FechaEmision = DateTime.Today,
                        FechaRendicion = DateTime.MinValue,
                        Estado = (GrupoE_Tutasa.Almacenes.EstadoHDRRetiroEnum)
                                 GrupoE_Tutasa.GenerarHDR.EstadoHDRRetiroEnum.PENDIENTE,
                        GuiaIds = guiasGrupo.Select(g => g.GuiaId).ToList()
                    });
                }
                else
                {
                    ultimoHDRDistribucionId++;

                    // ✅ agregar entidad directamente al almacén con conversión explícita de enum
                    HDRDistribucionAlmacen.hDRDistribucions.Add(new HDRDistribucionEntidad
                    {
                        HdrDistribucionId = ultimoHDRDistribucionId,
                        FleteroId = fletero.FleteroId,
                        FechaEmision = DateTime.Today,
                        FechaRendicion = DateTime.MinValue,
                        Estado = (GrupoE_Tutasa.Almacenes.EstadoHDRDistribucionEnum)
                                 GrupoE_Tutasa.GenerarHDR.EstadoHDRDistribucionEnum.PENDIENTE,
                        GuiaIds = guiasGrupo.Select(g => g.GuiaId).ToList()
                    });

                    // ✅ actualizar estado de guías en auxiliares y en almacén con conversión explícita
                    foreach (var g in guiasGrupo.Where(g => g.EstadoGuia == EstadoGuiaEnum.ADMITIDA || g.EstadoGuia == EstadoGuiaEnum.EN_CD_DESTINO))
                    {
                        g.EstadoGuia = EstadoGuiaEnum.EN_DISTRIBUCION;

                        var entidad = GuiaAlmacen.guias.FirstOrDefault(e => e.GuiaId == g.GuiaId);
                        if (entidad != null)
                        {
                            entidad.Estado = (GrupoE_Tutasa.Almacenes.EstadoGuiaEnum)
                                             GrupoE_Tutasa.GenerarHDR.EstadoGuiaEnum.EN_DISTRIBUCION;
                        }
                    }
                }
            }

            // ✅ guardar cambios en disco
            GuiaAlmacen.Guardar();
            HDRRetiroAlmacen.Guardar();
            HDRDistribucionAlmacen.Guardar();
            FleteroAlmacen.Guardar();
            ClienteAlmacen.Guardar();
        }
    }
}
