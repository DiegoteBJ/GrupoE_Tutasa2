using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EntregaEnCD
{
    public class Guia
    {
        public int GuiaId { get; set; }
        public int DestinatarioId { get; set; }
        public string Tamanio { get; set; } = "";
        public string Estado { get; set; } = "";
        public string UbicacionActual { get; set; } = "";
    }
}
