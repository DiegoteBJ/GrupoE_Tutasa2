using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    internal class fletero
    {
        // ── Modelo de datos ──────────────────────────────────────────────────────────

       
            public string NroGuia { get; set; }
            public string HDR { get; set; }
            public string Destino { get; set; }
            public string Tamaño { get; set; }
            public bool Cumplida { get; set; }
        

            public string DNI { get; set; }
            public string Nombre { get; set; }
    

        //Constructor con parametro

        public fletero (string dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        //Constructor sin parametro

        public fletero()
        { 
        }

    }
}
