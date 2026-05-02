using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EstadoCCClientes
{
    internal class Documentos
    {
        public int documentoId { get; set; }
        public int clienteId { get; set; } = 0;
        public string documentoTipo { get; set; }
        public DateTime documentoFecha { get; set; }
        public string documentoNumero { get; set; }
        public decimal documentoTotal { get; set; }
    }
}
