using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EmitirFactura
{
    internal class Documentos
    {
        public int documentoId { get; set; }
        public int clienteId { get; set; } = 0;
        public string documentoTipo { get; set; }
        public DateTime documentoFecha { get; set; }
        public string documentoNumero { get; set; }
        public decimal netoGravado { get; set; }

        public decimal ivaDF { get; set; }
        public decimal documentoTotal { get; set; }


        // Metodos de la clase Documentos
        public static int ObtenerUltimoId(List<Documentos> LDocumentos)
        {
            if (LDocumentos == null || LDocumentos.Count == 0)
            { return 0; }
            return LDocumentos.Max(d => d.documentoId);
        }

    }// acá finaliza la clase Documentos    
}