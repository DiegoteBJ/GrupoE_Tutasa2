using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.MonitoreoResultados
{
    internal class Documentos
    {
        public int documentoId { get; set; }
        public int proveedorId { get; set; } = 0;
        public string documentoTipo { get; set; }
        public DateTime documentoFecha { get; set; }
        public string documentoNumero { get; set; }
        public decimal documentoTotalsinIVA { get; set; }
    }
}
