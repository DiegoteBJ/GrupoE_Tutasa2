using System;

namespace GrupoE_Tutasa.Almacenes
{
    public class MovimientoEstadoGuiaEntidad
    {
        public int GuiaId { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public string Ubicacion { get; set; }
    }
}
