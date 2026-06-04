using System;
using System.Collections.Generic;

namespace GrupoE_Tutasa.Almacenes
{
    public enum EstadoHDRDistribucionEnum
    {
        PENDIENTE,
        RENDIDA
    }

    public class HDRDistribucionEntidad
    {
        public int HdrDistribucionId { get; set; }
        public int FleteroId { get; set; }
        public EstadoHDRDistribucionEnum Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRendicion { get; set; }
        public List<int> GuiaIds { get; set; }
    }
}
