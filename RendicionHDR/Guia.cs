using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RendicionHDR
{
    internal class Guia
    {
        public int guiaId { get; set; }

        public string numeroHDR { get; set; } = "";

        public string remitente { get; set; } = "";

        public string destinatario { get; set; } = "";

        public string domicilio { get; set; } = "";

        public string tamanio { get; set; } = "";

        public int intentosEntrega { get; set; }

        public string resultado { get; set; } = "Pendiente";
    }
}
