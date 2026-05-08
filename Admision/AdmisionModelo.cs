using GrupoE_Tutasa.EmitirFactura;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Admision
{
    internal class AdmisionModelo
    {
        public List<GuiasAImponer> LGuiasAImponer => new List<GuiasAImponer>
        {
            new GuiasAImponer { Id = 1, clienteID = 1, numeroGuia = "G001", fechaImposicion = new DateTime(2026, 04, 05), CDorigen = "Buenos Aires", CDdestino = "Rosario", tamaño = "L", importe = 15000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 2, clienteID = 2, numeroGuia = "G002", fechaImposicion = new DateTime(2026, 04, 06), CDorigen = "Córdoba", CDdestino = "Mendoza", tamaño = "M", importe = 10000 , estadoGuia="Impuesta"},
            new GuiasAImponer { Id = 3, clienteID = 3, numeroGuia = "G003", fechaImposicion = new DateTime(2026, 04, 07), CDorigen = "La Plata", CDdestino = "Mar del Plata", tamaño = "S", importe = 6000 , estadoGuia="Impuesta"},
            new GuiasAImponer { Id = 4, clienteID = 4, numeroGuia = "G004", fechaImposicion = new DateTime(2026, 04, 08), CDorigen = "San Juan", CDdestino = "Salta", tamaño = "XL", importe = 20000 , estadoGuia="Impuesta"},
            new GuiasAImponer { Id = 5, clienteID = 5, numeroGuia = "G005", fechaImposicion = new DateTime(2026, 04, 09), CDorigen = "Neuquén", CDdestino = "Bahía Blanca", tamaño = "M", importe = 11000 , estadoGuia="Impuesta"},
            new GuiasAImponer { Id = 6, clienteID = 6, numeroGuia = "G006", fechaImposicion = new DateTime(2026, 04, 10), CDorigen = "Tucumán", CDdestino = "Santa Fe", tamaño = "S", importe = 7000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 7, clienteID = 1, numeroGuia = "G007", fechaImposicion = new DateTime(2026, 04, 11), CDorigen = "Corrientes", CDdestino = "Posadas", tamaño = "XL", importe = 19000 , estadoGuia="Impuesta"},
            new GuiasAImponer { Id = 8, clienteID = 2, numeroGuia = "G008", fechaImposicion = new DateTime(2026, 04, 12), CDorigen = "Resistencia", CDdestino = "San Luis", tamaño = "L", importe = 14000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 9, clienteID = 3, numeroGuia = "G009", fechaImposicion = new DateTime(2026, 04, 13), CDorigen = "Catamarca", CDdestino = "Jujuy", tamaño = "M", importe = 9500, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 10, clienteID = 4, numeroGuia = "G010", fechaImposicion = new DateTime(2026, 04, 14), CDorigen = "Trelew", CDdestino = "Río Gallegos", tamaño = "S", importe = 7500 , estadoGuia="Impuesta"},
            new GuiasAImponer { Id = 11, clienteID = 1, numeroGuia = "G011", fechaImposicion = new DateTime(2026, 04, 15), CDorigen = "Buenos Aires", CDdestino = "Rosario", tamaño = "XL", importe = 20000 , estadoGuia="Impuesta"},
            new GuiasAImponer { Id = 12, clienteID = 2, numeroGuia = "G012", fechaImposicion = new DateTime(2026, 04, 16), CDorigen = "Córdoba", CDdestino = "Mendoza", tamaño = "L", importe = 15000 , estadoGuia="Impuesta"},
            new GuiasAImponer { Id = 13, clienteID = 3, numeroGuia = "G013", fechaImposicion = new DateTime(2026, 04, 17), CDorigen = "La Plata", CDdestino = "Mar del Plata", tamaño = "M", importe = 10000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 14, clienteID = 4, numeroGuia = "G014", fechaImposicion = new DateTime(2026, 04, 18), CDorigen = "San Juan", CDdestino = "Salta", tamaño = "S", importe = 6000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 15, clienteID = 1, numeroGuia = "G015", fechaImposicion = new DateTime(2026, 04, 19), CDorigen = "Neuquén", CDdestino = "Bahía Blanca", tamaño = "XL", importe = 20000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 16, clienteID = 2, numeroGuia = "G016", fechaImposicion = new DateTime(2026, 04, 20), CDorigen = "Tucumán", CDdestino = "Santa Fe", tamaño = "L", importe = 14000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 17, clienteID = 3, numeroGuia = "G017", fechaImposicion = new DateTime(2026, 04, 21), CDorigen = "Corrientes", CDdestino = "Posadas", tamaño = "M", importe = 11000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 18, clienteID = 4, numeroGuia = "G018", fechaImposicion = new DateTime(2026, 04, 22), CDorigen = "Resistencia", CDdestino = "San Luis", tamaño = "S", importe = 7000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 19, clienteID = 5, numeroGuia = "G019", fechaImposicion = new DateTime(2026, 04, 23), CDorigen = "Catamarca", CDdestino = "Jujuy", tamaño = "XL", importe = 19000, estadoGuia="Impuesta" },
            new GuiasAImponer { Id = 20, clienteID = 1, numeroGuia = "G020", fechaImposicion = new DateTime(2026, 04, 24), CDorigen = "Trelew", CDdestino = "Río Gallegos", tamaño = "L", importe = 15000, estadoGuia="Impuesta" },
        };
        
        public List<Cajas> LCajas => new List<Cajas>
        {
            new Cajas { ID = 1, nombre = "S" },
            new Cajas { ID = 2, nombre = "M" },
            new Cajas { ID = 3, nombre = "L" },
            new Cajas { ID = 4, nombre = "XL" }
        };
    }
}
