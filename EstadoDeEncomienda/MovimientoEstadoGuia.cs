using System;

namespace GrupoE_Tutasa.EstadoDeEncomienda
{
    public class MovimientoEstadoGuia
    {
        public int GuiaId { get; set; }

        public DateTime Fecha { get; set; }

        public string Estado { get; set; } = "";

        public string Ubicacion { get; set; } = "";
    }
}