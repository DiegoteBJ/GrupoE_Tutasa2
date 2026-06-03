using System;

namespace GrupoE_Tutasa.Almacenes
{
    public enum EstadoServicioTransporteEnum
    {
        PENDIENTE,
        EN_TRANSITO,
        LLEGADO
    }

    public class ServicioTransporteEntidad
    {
        public int ServicioId { get; set; }
        public int EmpresaTransporteId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaYHoraSalida { get; set; }
        public EstadoServicioTransporteEnum Estado { get; set; }
        public int CDOrigenId { get; set; }
        public int CDDestinoId { get; set; }
    }
}
