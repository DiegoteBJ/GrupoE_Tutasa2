using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class Fletero
    {

        public int FleteroId { get; set; }
       
        public string FleteroDNI { get; set; } = string.Empty;
        public string FleteroNombre { get; set; } = string.Empty;
        public string FleteroApellido { get; set; } = string.Empty;
        public List<string> CPCobertura { get; set; } = new List<string>();
    }
}
