using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RecepcionDespachoAgencia
{
    internal class Guia
    {
        public int guiaId { get; set; }  
        public string numeroHDR { get; set; } = "";
        public string tipo { get; set; } = "";
        public string estado { get; set; } = "";
    }
}
