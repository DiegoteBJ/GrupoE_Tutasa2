using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal enum EstadoHDRDistribucionEnum
    {
        PENDIENTE,
        RENDIDA
    }
    internal class HDRDistribucion
    {
        public int HDRDistribucionId { get; set; }
        public int fleteroId { get; set; }
        public EstadoHDRDistribucionEnum Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRendicion { get; set; }
        public List<int> GuiaIds { get; set; }

    }
}
