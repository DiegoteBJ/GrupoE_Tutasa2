using GrupoE_Tutasa.EmitirFactura;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EmitirFactura
{
    internal class Guias
    {
        public int guiaId { get; set; }
        public int clienteId { get; set; }
        public string apellidoDestinatario { get; set; }
        public string nombreDestinatario { get; set; }
        public string tipoCaja { get; set; }
        public int tarifarioId { get; set; }
    }
}
