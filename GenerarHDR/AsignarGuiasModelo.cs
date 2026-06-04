using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class AsignarGuiasModelo
    {

        public List<Guias> LGuiasAAsignar { get; set; } = new List<Guias>()

                {
                    new Guias
                    {
                        GuiaId = 1,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle Falsa",
                            Numero = "123",
                            CodigoPostal = "C1000",
                            Localidad = "Buenos Aires",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "L",
                        EstadoGuia = "A retirar",
                        NombreDestinatarioGuia = "Juan Pérez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Calle Verdadera",
                            Numero = "456",
                            CodigoPostal = "2000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 2,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle Falsa",
                            Numero = "123",
                            CodigoPostal = "C1000",
                            Localidad = "Buenos Aires",
                            Provincia = "Buenos Aires"

                        },
                        tamañoGuia = "M",
                        EstadoGuia = "A retirar",
                        NombreDestinatarioGuia = "María Gómez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "789",
                            CodigoPostal = "2000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 3,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Boulevard de los Sueños Rotos",
                            Numero = "789",
                            CodigoPostal = "3000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "S",
                        EstadoGuia = "A retirar",
                        NombreDestinatarioGuia = "Carlos Rodríguez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Boulevard Real",
                            Numero = "321",
                            CodigoPostal = "7700",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 4,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle del Olvido",
                            Numero = "321",
                            CodigoPostal = "4000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "XL",
                        EstadoGuia = "A retirar",
                        NombreDestinatarioGuia = "Ana Martínez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Calle Real",
                            Numero = "654",
                            CodigoPostal = "2000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 5,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Avenida de la Esperanza",
                            Numero = "654",
                            CodigoPostal = "5000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "M",
                        EstadoGuia = "Admitida",
                        NombreDestinatarioGuia = "Luis Fernández",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "987",
                            CodigoPostal = "C1001",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 6,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle de la Fortuna",
                            Numero = "987",
                            CodigoPostal = "6000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "S",
                        EstadoGuia = "Admitida",
                        NombreDestinatarioGuia = "Sofía López",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Calle Real",
                            Numero = "987",
                            CodigoPostal = "C1003",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 7,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Avenida del Destino",
                            Numero = "159",
                            CodigoPostal = "7000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "XL",
                        EstadoGuia = "Admitida",
                        NombreDestinatarioGuia = "Miguel Sánchez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "159",
                            CodigoPostal = "C1000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 8,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle de la Ilusión",
                            Numero = "753",
                            CodigoPostal = "8000",
                            Localidad = "Buenos Aires",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "L",
                        EstadoGuia = "Admitida",
                        NombreDestinatarioGuia = "Laura Gómez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "852",
                            CodigoPostal = "C1000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                    new Guias
                    {
                        GuiaId = 9,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Avenida de la Libertad",
                            Numero = "852",
                            CodigoPostal = "9000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        tamañoGuia = "M",
                        EstadoGuia = "En distribución",
                        NombreDestinatarioGuia = "Jorge Rodríguez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "852",
                            CodigoPostal = "C1000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 2
                    },
                    new Guias
                    {
                        GuiaId = 10,
                        DomicilioRetiro = new Domicilio
                        {
                            Calle = "Calle Falsa",
                            Numero = "123",
                            CodigoPostal = "1000",
                            Localidad = "Buenos Aires",
                            Provincia = "Buenos Aires"

                        },
                        tamañoGuia = "M",
                        EstadoGuia = "Impuesta Telefónicamente",
                        NombreDestinatarioGuia = "María Gómez",
                        DomicilioEntrega = new Domicilio
                        {
                            Calle = "Avenida Real",
                            Numero = "7819",
                            CodigoPostal = "C1000",
                            Localidad = "CABA",
                            Provincia = "Buenos Aires"
                        },
                        IntentosDeEntrega = 0
                    },
                };

        public List<Fleteros> LFleteros { get; set; } = new List<Fleteros>()

                {
                    new Fleteros { FleteroId = 1, FleteroDNI = "12345678", FleteroNombre = "Jorge", FleteroApellido = "Perez", CPCobertura = new List<string> { "C1000", "C1001", "C1002" } },
                    new Fleteros { FleteroId = 2, FleteroDNI = "23456789", FleteroNombre = "Gaston", FleteroApellido = "Gonzales", CPCobertura = new List<string> { "C2000", "C2001", "C2002", "C2003" } },
                    new Fleteros { FleteroId = 3, FleteroDNI = "33333333", FleteroNombre = "Pedro", FleteroApellido = "Rodriguez", CPCobertura = new List<string> { "C3000", "C3001", "C3002" } },
                    new Fleteros { FleteroId = 4, FleteroDNI = "7777777", FleteroNombre = "Julio", FleteroApellido = "Contreras", CPCobertura = new List<string> { "C4000", "C4001", "C4002" } },
                };

        // Listas HDR generadas
        public List<HDRRetiro> HDRsRetiro { get; set; } = new List<HDRRetiro>()
        {
            new HDRRetiro
            {
                HDRRetiroId = 1,
             
                fleteroId = 1,
                FechaEmision = DateTime.Now.AddDays(-1),
                FechaRendicion = DateTime.MinValue, // aún no rendida
                Estado = "Pendiente",
                GuiasIds = new List<int> { 0, 0 } // varias guías al mismo domicilio
            },
            new HDRRetiro
            {
                HDRRetiroId = 2,
               
                fleteroId = 2,
                FechaEmision = DateTime.Now.AddDays(-2),
                FechaRendicion = DateTime.MinValue,
                Estado = "Pendiente",
                GuiasIds = new List<int> { 0, 0 } // varias guías al mismo domicilio
            }
        };

        public List<HDRDistribucion> HDRsDistribucion { get; set; } = new List<HDRDistribucion>()
        {
            new HDRDistribucion
            {
                HDRDistribucionId = 1,
               
                fleteroId = 1,
                FechaEmision = DateTime.Now.AddDays(-1),
                FechaRendicion = DateTime.MinValue, // aún no rendida
                Estado = "Pendiente",
                GuiasIds = new List<int> { 0, 0 } // varias guías al mismo domicilio
            },
            new HDRDistribucion
            {
                HDRDistribucionId = 2,
               
                fleteroId = 2,
                FechaEmision = DateTime.Now.AddDays(-2),
                FechaRendicion = DateTime.MinValue,
                Estado = "Pendiente",
                GuiasIds = new List<int> { 0, 0 } // varias guías al mismo domicilio
            },


        };

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
