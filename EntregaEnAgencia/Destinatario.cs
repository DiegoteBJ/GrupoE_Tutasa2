using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EntregaEnAgencia
{
    public class Destinatario
    {
        public int DestinatarioId { get; set; }
        public long Dni { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
    }
}
