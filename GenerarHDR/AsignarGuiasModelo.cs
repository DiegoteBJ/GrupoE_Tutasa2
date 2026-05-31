using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class AsignarGuiasModelo
    {

        public List<GuiasAAsignar> LGuiasAAsignar
        {
            get
            {
                return new List<GuiasAAsignar>
                {
                    new GuiasAAsignar { GuiaId = 1, CodigoPostalGuia = "1000", Domicilio = "Calle Falsa 123", tamaño = "L", EstadoGuia = "A retirar", NombreDestinatarioGuia = "Juan Pérez" },
                    new GuiasAAsignar { GuiaId = 2, CodigoPostalGuia = "2000", Domicilio = "Avenida Siempre Viva 456", tamaño = "M", EstadoGuia = "A retirar", NombreDestinatarioGuia = "María Gómez" },
                    new GuiasAAsignar { GuiaId = 3, CodigoPostalGuia = "3000", Domicilio = "Boulevard de los Sueños Rotos 789", tamaño = "S", EstadoGuia = "A retirar", NombreDestinatarioGuia = "Carlos Rodríguez" },
                    new GuiasAAsignar { GuiaId = 4, CodigoPostalGuia = "4000", Domicilio = "Calle del Olvido 321", tamaño = "XL", EstadoGuia = "A retirar", NombreDestinatarioGuia = "Ana Martínez" },
                    new GuiasAAsignar { GuiaId = 5, CodigoPostalGuia = "5000", Domicilio = "Avenida de la Esperanza 654", tamaño = "M", EstadoGuia = "Admitida", NombreDestinatarioGuia = "Luis Fernández" },
                    new GuiasAAsignar { GuiaId = 6, CodigoPostalGuia = "6000", Domicilio = "Calle de la Fortuna 987", tamaño = "S", EstadoGuia = "Admitida", NombreDestinatarioGuia = "Sofía López" },
                    new GuiasAAsignar { GuiaId = 7, CodigoPostalGuia = "7000", Domicilio = "Avenida del Destino 159", tamaño = "XL", EstadoGuia = "Admitida", NombreDestinatarioGuia = "Miguel Sánchez" },
                    new GuiasAAsignar { GuiaId = 8, CodigoPostalGuia = "8000", Domicilio = "Calle de la Ilusión 753", tamaño = "L", EstadoGuia = "Admitida", NombreDestinatarioGuia = "Laura Gómez" },
                };
            }
        }

        public List<Fleteros> LFleteros
        {
            get
            {
                return new List<Fleteros>
                {
                    new Fleteros { FleteroId = 1, FleteroDNI = "11111111", FleteroNombre = "Fletero A", FleteroApellido = "Apellido A" },
                    new Fleteros { FleteroId = 2, FleteroDNI = "22222222", FleteroNombre = "Fletero B", FleteroApellido = "Apellido B" },
                    new Fleteros { FleteroId = 3, FleteroDNI = "33333333", FleteroNombre = "Fletero C", FleteroApellido = "Apellido C" },
                    new Fleteros { FleteroId = 4, FleteroDNI = "7777777", FleteroNombre = "Fletero D", FleteroApellido = "Apellido D" },
                };
            }
        }

        public static bool ValidarDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return false;

            // Intentar convertir a número
            if (!int.TryParse(dni, out int numero))
                return false;

            // Validar longitud (7 u 8 dígitos)
            if (dni.Length < 7 || dni.Length > 8)
                return false;

            return true;
        }

    }
}
