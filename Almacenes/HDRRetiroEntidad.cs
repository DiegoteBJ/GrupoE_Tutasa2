using System;
using System.Collections.Generic;

namespace GrupoE_Tutasa.Almacenes
{
    public enum EstadoHDRRetiroEnum
    {
        PENDIENTE,
        RENDIDA
    }

    public class HDRRetiroEntidad
    {
        public int HdrRetiroId { get; set; }
        public int FleteroId { get; set; }
        public EstadoHDRRetiroEnum Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRendicion { get; set; }
        public List<int> GuiaIds { get; set; }
    }
}
