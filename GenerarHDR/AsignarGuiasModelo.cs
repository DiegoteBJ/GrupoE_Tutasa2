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
                    new GuiasAAsignar { GuiaId = 1, CodigoPostalGuia = "1000", DomicilioGuia = "Calle Falsa 123", tamañoGuia = "L", EstadoGuia = "A retirar", NombreDestinatarioGuia = "Juan Pérez" },
                    new GuiasAAsignar { GuiaId = 2, CodigoPostalGuia = "2000", DomicilioGuia = "Avenida Siempre Viva 456", tamañoGuia = "M", EstadoGuia = "A retirar", NombreDestinatarioGuia = "María Gómez" },
                    new GuiasAAsignar { GuiaId = 3, CodigoPostalGuia = "3000", DomicilioGuia = "Boulevard de los Sueños Rotos 789", tamañoGuia = "S", EstadoGuia = "A retirar", NombreDestinatarioGuia = "Carlos Rodríguez" },
                    new GuiasAAsignar { GuiaId = 4, CodigoPostalGuia = "4000", DomicilioGuia = "Calle del Olvido 321", tamañoGuia = "XL", EstadoGuia = "A retirar", NombreDestinatarioGuia = "Ana Martínez" },
                    new GuiasAAsignar { GuiaId = 5, CodigoPostalGuia = "5000", DomicilioGuia = "Avenida de la Esperanza 654", tamañoGuia = "M", EstadoGuia = "Admitida", NombreDestinatarioGuia = "Luis Fernández" },
                    new GuiasAAsignar { GuiaId = 6, CodigoPostalGuia = "6000", DomicilioGuia = "Calle de la Fortuna 987", tamañoGuia = "S", EstadoGuia = "Admitida", NombreDestinatarioGuia = "Sofía López" },
                    new GuiasAAsignar { GuiaId = 7, CodigoPostalGuia = "7000", DomicilioGuia = "Avenida del Destino 159", tamañoGuia = "XL", EstadoGuia = "Admitida", NombreDestinatarioGuia = "Miguel Sánchez" },
                    new GuiasAAsignar { GuiaId = 8, CodigoPostalGuia = "8000", DomicilioGuia = "Calle de la Ilusión 753", tamañoGuia = "L", EstadoGuia = "Admitida", NombreDestinatarioGuia = "Laura Gómez" },
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

        public static bool ValidarDniString(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni)) return false;
            // Sólo dígitos ya garantizados por TextChanged, pero volvemos a intentar parsear
            if (!int.TryParse(dni, out int numero)) return false;
            if (numero < 0) return false;
            return dni.Length == 7 || dni.Length == 8;
        }

    }
}
