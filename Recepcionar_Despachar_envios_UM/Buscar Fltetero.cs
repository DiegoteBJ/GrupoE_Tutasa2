using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    internal class Buscar_Fletero
    {
        private fletero Fletero1;
        private fletero Fletero2;

        public Buscar_Fletero()
        {
            // Usar el constructor con parámetros
            Fletero1 = new fletero("12345678", "Juan");

            Fletero2 = new fletero();
            Fletero2.DNI = "87654321";
            Fletero2.Nombre = "Pepito";

            GrupoE_Tutasa.Recepcionar_Despachar_envios_UM.fletero Fletero3 = new GrupoE_Tutasa.Recepcionar_Despachar_envios_UM.fletero();
            Fletero3.DNI = "23456789";
            Fletero3.Nombre = "Carlos";

        }

        public void MostrarDatos()
        {
            Console.WriteLine($"DNI: {Fletero1.DNI}, Nombre: {Fletero1.Nombre}");
        }

        
    }
}
