using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class Guia
    {
        public int GuiaId { get; set; }
        
        public Domicilio DomicilioRetiro { get; set; } = new Domicilio();
        public Domicilio DomicilioEntrega { get; set; } = new Domicilio();
        public string tamañoGuia { get; set; }
        public string EstadoGuia { get; set; }
        public string NombreDestinatarioGuia { get; set; }
        public int IntentosDeEntrega { get; set; }  // contador de intentos
    }
}

