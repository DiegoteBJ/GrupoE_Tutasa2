using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    internal class Buscarfletero1
    {
        // fletero.cs
        public class fletero
        {
            public string DNI { get; set; }
            public string Nombre { get; set; }

            // Lista de guías asignadas a este fletero
            public List<guia> Guias { get; set; }

            public fletero(string dni, string nombre)
            {
                DNI = dni;
                Nombre = nombre;
                Guias = new List<guia>(); // Inicio de la lista vacía
            }

            public fletero()
            {
                Guias = new List<guia>();
            }
        }
    }
}
