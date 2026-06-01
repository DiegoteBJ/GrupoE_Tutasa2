using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class HDRDistribucion
    {
        public int HDRDistribucionId { get; set; }
        public int GuiaId { get; set; }
        public int fleteroId { get; set; }
        public DateTime FechaEmision { get; set; } = DateTime.Now;
        public DateTime FechaRendicion { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public string Observaciones { get; set; } = string.Empty;
    }
}
