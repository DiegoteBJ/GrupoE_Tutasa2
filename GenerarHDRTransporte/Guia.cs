using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDRTransporte
    {
        public class Guia
        {
            public string NroGuia { get; set; }
            public string Tamaño { get; set; }
            public string Destino { get; set; }
            public string CDActual { get; set; }    // CD donde está actualmente la guía
            public string Estado { get; set; }
    }
    }

// filtrar todas las guias en estado admitidas. ademas el CD actual es distinto del CD destino. (condiciones)
// el CD actual debe ser igual al CD del operario que esta generando el HDR. (condicion)