using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class HDRRetiro
    {
        public int HDRRetiroId { get; set; }
        public int GuiaId { get; set; }
        public int fleteroId { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRendicion { get; set; }
        public string Estado { get; set; } = "Pendiente";
        public string Observaciones { get; set; } = string.Empty;
    }
}
