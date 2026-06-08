using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RendicionHDR
{
    internal class HDRRetiro
    {
        public string numeroHDR { get; set; } = "";
        public long fleteroDNI { get; set; }
        public DateTime fechaHDR { get; set; }
        public string estadoHDR { get; set; } = "";

        public List<int> GuiaIds { get; set; } = new();
    }
}
