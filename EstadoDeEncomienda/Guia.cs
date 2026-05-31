using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EstadoDeEncomienda
{
    public class Guia
    {
        public int GuiaId { get; set; }

        public List<MovimientoEstadoGuia> MovimientosEstado { get; set; }
            = new List<MovimientoEstadoGuia>();
    }
}
