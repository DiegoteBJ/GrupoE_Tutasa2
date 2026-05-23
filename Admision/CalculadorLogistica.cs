using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Admision
{
    internal class CalculadorLogistica
    {
        // Diccionario de distancias (Matriz de 20x20)
        // Clave: (Origen, Destino), Valor: Kilómetros
        private static readonly Dictionary<(string, string), int> MatrizDistancias = new Dictionary<(string, string), int>
        {
            { ("Buenos Aires", "Rosario"), 300 }, { ("Buenos Aires", "Córdoba"), 700 }, { ("Buenos Aires", "Mendoza"), 1050 }, { ("Buenos Aires", "La Plata"), 60 }, { ("Buenos Aires", "Mar del Plata"), 415 }, { ("Buenos Aires", "San Juan"), 1100 }, { ("Buenos Aires", "Salta"), 1490 }, { ("Buenos Aires", "Neuquén"), 1150 }, { ("Buenos Aires", "Bahía Blanca"), 640 }, { ("Buenos Aires", "Tucumán"), 1250 }, { ("Buenos Aires", "Santa Fe"), 470 }, { ("Buenos Aires", "Corrientes"), 920 }, { ("Buenos Aires", "Posadas"), 1000 }, { ("Buenos Aires", "Resistencia"), 930 }, { ("Buenos Aires", "San Luis"), 790 }, { ("Buenos Aires", "Catamarca"), 1130 }, { ("Buenos Aires", "Jujuy"), 1500 }, { ("Buenos Aires", "La Rioja"), 1150 }, { ("Buenos Aires", "Formosa"), 1180 },
            { ("Rosario", "Córdoba"), 400 }, { ("Rosario", "Mendoza"), 850 }, { ("Rosario", "La Plata"), 350 }, { ("Rosario", "Mar del Plata"), 710 }, { ("Rosario", "San Juan"), 900 }, { ("Rosario", "Salta"), 1200 }, { ("Rosario", "Neuquén"), 1100 }, { ("Rosario", "Bahía Blanca"), 760 }, { ("Rosario", "Tucumán"), 950 }, { ("Rosario", "Santa Fe"), 170 }, { ("Rosario", "Corrientes"), 630 }, { ("Rosario", "Posadas"), 800 }, { ("Rosario", "Resistencia"), 640 }, { ("Rosario", "San Luis"), 610 }, { ("Rosario", "Catamarca"), 830 }, { ("Rosario", "Jujuy"), 1210 }, { ("Rosario", "La Rioja"), 850 }, { ("Rosario", "Formosa"), 890 },
            { ("Córdoba", "Mendoza"), 610 }, { ("Córdoba", "La Plata"), 760 }, { ("Córdoba", "Mar del Plata"), 1100 }, { ("Córdoba", "San Juan"), 580 }, { ("Córdoba", "Salta"), 890 }, { ("Córdoba", "Neuquén"), 1100 }, { ("Córdoba", "Bahía Blanca"), 1050 }, { ("Córdoba", "Tucumán"), 550 }, { ("Córdoba", "Santa Fe"), 350 }, { ("Córdoba", "Corrientes"), 900 }, { ("Córdoba", "Posadas"), 1100 }, { ("Córdoba", "Resistencia"), 850 }, { ("Córdoba", "San Luis"), 430 }, { ("Córdoba", "Catamarca"), 440 }, { ("Córdoba", "Jujuy"), 910 }, { ("Córdoba", "La Rioja"), 450 }, { ("Córdoba", "Formosa"), 1100 },
            { ("Mendoza", "La Plata"), 1100 }, { ("Mendoza", "Mar del Plata"), 1350 }, { ("Mendoza", "San Juan"), 170 }, { ("Mendoza", "Salta"), 1240 }, { ("Mendoza", "Neuquén"), 800 }, { ("Mendoza", "Bahía Blanca"), 1200 }, { ("Mendoza", "Tucumán"), 950 }, { ("Mendoza", "Santa Fe"), 900 }, { ("Mendoza", "Corrientes"), 1400 }, { ("Mendoza", "Posadas"), 1600 }, { ("Mendoza", "Resistencia"), 1350 }, { ("Mendoza", "San Luis"), 260 }, { ("Mendoza", "Catamarca"), 750 }, { ("Mendoza", "Jujuy"), 1300 }, { ("Mendoza", "La Rioja"), 450 }, { ("Mendoza", "Formosa"), 1600 },
            { ("La Plata", "Mar del Plata"), 365 }, { ("La Plata", "San Juan"), 1150 }, { ("La Plata", "Salta"), 1550 }, { ("La Plata", "Neuquén"), 1140 }, { ("La Plata", "Bahía Blanca"), 630 }, { ("La Plata", "Tucumán"), 1300 }, { ("La Plata", "Santa Fe"), 520 }, { ("La Plata", "Corrientes"), 970 }, { ("La Plata", "Posadas"), 1050 }, { ("La Plata", "Resistencia"), 980 }, { ("La Plata", "San Luis"), 840 }, { ("La Plata", "Catamarca"), 1180 }, { ("La Plata", "Jujuy"), 1560 }, { ("La Plata", "La Rioja"), 1200 }, { ("La Plata", "Formosa"), 1230 },
            { ("Mar del Plata", "San Juan"), 1400 }, { ("Mar del Plata", "Salta"), 1900 }, { ("Mar del Plata", "Neuquén"), 1050 }, { ("Mar del Plata", "Bahía Blanca"), 450 }, { ("Mar del Plata", "Tucumán"), 1650 }, { ("Mar del Plata", "Santa Fe"), 880 }, { ("Mar del Plata", "Corrientes"), 1330 }, { ("Mar del Plata", "Posadas"), 1410 }, { ("Mar del Plata", "Resistencia"), 1340 }, { ("Mar del Plata", "San Luis"), 1100 }, { ("Mar del Plata", "Catamarca"), 1540 }, { ("Mar del Plata", "Jujuy"), 1910 }, { ("Mar del Plata", "La Rioja"), 1450 }, { ("Mar del Plata", "Formosa"), 1590 },
            { ("San Juan", "Salta"), 1080 }, { ("San Juan", "Neuquén"), 950 }, { ("San Juan", "Bahía Blanca"), 1350 }, { ("San Juan", "Tucumán"), 800 }, { ("San Juan", "Santa Fe"), 950 }, { ("San Juan", "Corrientes"), 1350 }, { ("San Juan", "Posadas"), 1550 }, { ("San Juan", "Resistencia"), 1300 }, { ("San Juan", "San Luis"), 320 }, { ("San Juan", "Catamarca"), 600 }, { ("San Juan", "Jujuy"), 1150 }, { ("San Juan", "La Rioja"), 440 }, { ("San Juan", "Formosa"), 1550 },
            { ("Salta", "Neuquén"), 2050 }, { ("Salta", "Bahía Blanca"), 1900 }, { ("Salta", "Tucumán"), 310 }, { ("Salta", "Santa Fe"), 1030 }, { ("Salta", "Corrientes"), 830 }, { ("Salta", "Posadas"), 1030 }, { ("Salta", "Resistencia"), 820 }, { ("Salta", "San Luis"), 1150 }, { ("Salta", "Catamarca"), 520 }, { ("Salta", "Jujuy"), 90 }, { ("Salta", "La Rioja"), 670 }, { ("Salta", "Formosa"), 1000 },
            { ("Neuquén", "Bahía Blanca"), 540 }, { ("Neuquén", "Tucumán"), 1750 }, { ("Neuquén", "Santa Fe"), 1250 }, { ("Neuquén", "Corrientes"), 1950 }, { ("Neuquén", "Posadas"), 2100 }, { ("Neuquén", "Resistencia"), 1900 }, { ("Neuquén", "San Luis"), 850 }, { ("Neuquén", "Catamarca"), 1550 }, { ("Neuquén", "Jujuy"), 2100 }, { ("Neuquén", "La Rioja"), 1250 }, { ("Neuquén", "Formosa"), 2150 },
            { ("Bahía Blanca", "Tucumán"), 1600 }, { ("Bahía Blanca", "Santa Fe"), 930 }, { ("Bahía Blanca", "Corrientes"), 1450 }, { ("Bahía Blanca", "Posadas"), 1550 }, { ("Bahía Blanca", "Resistencia"), 1400 }, { ("Bahía Blanca", "San Luis"), 900 }, { ("Bahía Blanca", "Catamarca"), 1450 }, { ("Bahía Blanca", "Jujuy"), 1950 }, { ("Bahía Blanca", "La Rioja"), 1350 }, { ("Bahía Blanca", "Formosa"), 1650 },
            { ("Tucumán", "Santa Fe"), 780 }, { ("Tucumán", "Corrientes"), 750 }, { ("Tucumán", "Posadas"), 950 }, { ("Tucumán", "Resistencia"), 740 }, { ("Tucumán", "San Luis"), 850 }, { ("Tucumán", "Catamarca"), 230 }, { ("Tucumán", "Jujuy"), 340 }, { ("Tucumán", "La Rioja"), 440 }, { ("Tucumán", "Formosa"), 920 },
            { ("Santa Fe", "Corrientes"), 560 }, { ("Santa Fe", "Posadas"), 740 }, { ("Santa Fe", "Resistencia"), 540 }, { ("Santa Fe", "San Luis"), 650 }, { ("Santa Fe", "Catamarca"), 660 }, { ("Santa Fe", "Jujuy"), 1040 }, { ("Santa Fe", "La Rioja"), 700 }, { ("Santa Fe", "Formosa"), 800 },
            { ("Corrientes", "Posadas"), 320 }, { ("Corrientes", "Resistencia"), 20 }, { ("Corrientes", "San Luis"), 1150 }, { ("Corrientes", "Catamarca"), 850 }, { ("Corrientes", "Jujuy"), 860 }, { ("Corrientes", "La Rioja"), 1000 }, { ("Corrientes", "Formosa"), 190 },
            { ("Posadas", "Resistencia"), 340 }, { ("Posadas", "San Luis"), 1350 }, { ("Posadas", "Catamarca"), 1050 }, { ("Posadas", "Jujuy"), 1060 }, { ("Posadas", "La Rioja"), 1200 }, { ("Posadas", "Formosa"), 310 },
            { ("Resistencia", "San Luis"), 1150 }, { ("Resistencia", "Catamarca"), 840 }, { ("Resistencia", "Jujuy"), 850 }, { ("Resistencia", "La Rioja"), 990 }, { ("Resistencia", "Formosa"), 170 },
            { ("San Luis", "Catamarca"), 650 }, { ("San Luis", "Jujuy"), 1200 }, { ("San Luis", "La Rioja"), 450 }, { ("San Luis", "Formosa"), 1320 },
            { ("Catamarca", "Jujuy"), 440 }, { ("Catamarca", "La Rioja"), 150 }, { ("Catamarca", "Formosa"), 1010 },
            { ("Jujuy", "La Rioja"), 600 }, { ("Jujuy", "Formosa"), 1030 },
            { ("La Rioja", "Formosa"), 1160 }
        };

        public static int ObtenerDistancia(string origen, string destino)
        {
            if (origen == destino) return 0;

            // Intentamos buscar A -> B
            if (MatrizDistancias.TryGetValue((origen, destino), out int d1)) return d1;

            // Si no existe, buscamos B -> A (Inversa)
            if (MatrizDistancias.TryGetValue((destino, origen), out int d2)) return d2;

            return 0;
        }

        public static decimal CalcularTransporte(string CDOrigen, string CDDestino, string tamaño, int clienteID)
        {
            int km = ObtenerDistancia(CDOrigen, CDDestino);
            decimal descuento = 0.0m;
            foreach (var tarifa in new AdmisionModelo().LTarifaCliente)
            {
                if (tarifa.clienteID == clienteID)
                {
                    descuento = tarifa.descuentoxKm;
                }
            }
            decimal factorTamaño = tamaño switch
            {
                "S" => 1.0m,
                "M" => 1.5m,
                "L" => 3.0m,
                "XL" => 6.0m,
            };

            decimal precioBase = 10.0m; // Precio base por km
            decimal transporte = (decimal)km * factorTamaño * (1 - descuento) * precioBase;
            if (transporte <= 0)
            {
                transporte = 5000;
            }
            return transporte;
        }
        public static decimal CalcularImposicion(int clienteID, string tipoImposicion)
        {
            decimal imposicion = tipoImposicion switch
            {
                "A" => 0m,
                "C" => 0m,
                "D" => 10000.0m,
            };
            return imposicion;
        }
        public static decimal CalcularEntrega(int clienteID, string tipoEntrega)
        {
            decimal entrega = tipoEntrega switch
            {
                "A" => 5000.0m,
                "C" => 0m,
                "D" => 10000.0m,
            };
            return entrega;
        }
    }
}