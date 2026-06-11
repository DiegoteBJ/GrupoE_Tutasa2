using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal enum EstadoHDRRetiroEnum
    {
        PENDIENTE,
        RENDIDA
    }
    internal class HDRRetiro
    {
        public int HdrRetiroId { get; set; }
        public int FleteroId { get; set; }
        public EstadoHDRRetiroEnum Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRendicion { get; set; }
        public List<int> GuiaIds { get; set; }
    }
}
