using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Recepcionar_Despachar_envios_UM
{
    internal class Fletero
    {
        private fletero Fletero1;
        private fletero Fletero2;

        public Fletero()
        {
            // Usar el constructor con parámetros
            //prueba 22:01
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

        public class Guia
        {
            public Guia()
             {
                GrupoE_Tutasa.Recepcionar_Despachar_envios_UM.guia encomienda1 = new GrupoE_Tutasa.Recepcionar_Despachar_envios_UM.guia();
                {
                encomienda1.NroGuia = "001-001";
                encomienda1.HDR = "123";
                encomienda1.Destino = "Salta";
                encomienda1.Tamaño = "G";
                encomienda1.Cumplida = true; 
                }
            }
        }
}
