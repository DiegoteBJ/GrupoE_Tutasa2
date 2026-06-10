using GrupoE_Tutasa.Almacenes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal enum EstadoHDRDistribucionEnume
    {
        PENDIENTE,
        RENDIDA
    }
    internal class HDRDistribucionww
    {
        public int HdrDistribucionId { get; set; }
        public int FleteroId { get; set; }
        public EstadoHDRDistribucionEnume Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaRendicion { get; set; }
        public List<int> GuiaIds { get; set; }

    }
}
