using System;
using System.Collections.Generic;

namespace GrupoE_Tutasa.Almacenes
{
    public enum EstadoHDRTransporteEnum
    {
        PENDIENTE,
        EN_TRANSITO,
        RENDIDA
    }

    public class HDRTransporteEntidad
    {
        public int HdrTransporteId { get; set; }
        public int ServicioId { get; set; }
        public int CDOrigenId { get; set; }
        public int CDDestinoId { get; set; }
        public EstadoHDRTransporteEnum Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<int> GuiaIds { get; set; }
    }
}
