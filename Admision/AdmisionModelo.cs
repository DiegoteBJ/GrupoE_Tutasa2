using GrupoE_Tutasa.EmitirFactura;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Admision
{
    internal class AdmisionModelo
    {
        public List<GuiasAAdmitir> LGuiasAAdmitir => new List<GuiasAAdmitir>
        {
            new GuiasAAdmitir { Id = 1, clienteID = 1, numeroGuia = 001, fechaImposicion = new DateTime(2026, 04, 05), CDorigen = "Buenos Aires", CDdestino = "Rosario", tamaño = "L", importe = 15000, estadoGuia="Impuesta", tipoImposicion="A", tipoEntrega="D" },
            new GuiasAAdmitir { Id = 2, clienteID = 2, numeroGuia = 002, fechaImposicion = new DateTime(2026, 04, 06), CDorigen = "Córdoba", CDdestino = "Mendoza", tamaño = "M", importe = 10000 , estadoGuia="Impuesta", tipoImposicion="C", tipoEntrega="D"},
            new GuiasAAdmitir { Id = 3, clienteID = 3, numeroGuia = 003, fechaImposicion = new DateTime(2026, 04, 07), CDorigen = "La Plata", CDdestino = "Mar del Plata", tamaño = "S", importe = 6000 , estadoGuia="Impuesta", tipoImposicion="D", tipoEntrega="C"},
            new GuiasAAdmitir { Id = 4, clienteID = 4, numeroGuia = 004, fechaImposicion = new DateTime(2026, 04, 08), CDorigen = "San Juan", CDdestino = "Salta", tamaño = "XL", importe = 20000 , estadoGuia="Impuesta", tipoImposicion="A", tipoEntrega="C"},
            new GuiasAAdmitir { Id = 5, clienteID = 5, numeroGuia = 005, fechaImposicion = new DateTime(2026, 04, 09), CDorigen = "Neuquén", CDdestino = "Bahía Blanca", tamaño = "M", importe = 11000 , estadoGuia="Impuesta", tipoImposicion="C", tipoEntrega="A"},
            new GuiasAAdmitir { Id = 6, clienteID = 6, numeroGuia = 006, fechaImposicion = new DateTime(2026, 04, 10), CDorigen = "Tucumán", CDdestino = "Santa Fe", tamaño = "S", importe = 7000, estadoGuia="Impuesta", tipoImposicion="D", tipoEntrega="C" },
            new GuiasAAdmitir { Id = 7, clienteID = 1, numeroGuia = 007, fechaImposicion = new DateTime(2026, 04, 11), CDorigen = "Corrientes", CDdestino = "Posadas", tamaño = "XL", importe = 19000 , estadoGuia="Impuesta", tipoImposicion="A", tipoEntrega="C"},
            new GuiasAAdmitir { Id = 8, clienteID = 2, numeroGuia = 008, fechaImposicion = new DateTime(2026, 04, 12), CDorigen = "Resistencia", CDdestino = "San Luis", tamaño = "L", importe = 14000, estadoGuia="Impuesta", tipoImposicion="C", tipoEntrega="A" },
            new GuiasAAdmitir { Id = 9, clienteID = 3, numeroGuia = 009, fechaImposicion = new DateTime(2026, 04, 13), CDorigen = "Catamarca", CDdestino = "Jujuy", tamaño = "M", importe = 9500, estadoGuia="Impuesta", tipoImposicion="D", tipoEntrega="C" },
            new GuiasAAdmitir { Id = 10, clienteID = 4, numeroGuia = 010, fechaImposicion = new DateTime(2026, 04, 14), CDorigen = "Catamarca", CDdestino = "Buenos Aires", tamaño = "S", importe = 7500 , estadoGuia="Impuesta", tipoImposicion="A", tipoEntrega="C"},
            new GuiasAAdmitir { Id = 11, clienteID = 1, numeroGuia = 011, fechaImposicion = new DateTime(2026, 04, 15), CDorigen = "Buenos Aires", CDdestino = "Rosario", tamaño = "XL", importe = 20000 , estadoGuia="Impuesta",tipoImposicion="C", tipoEntrega = "A"},
            new GuiasAAdmitir { Id = 12, clienteID = 2, numeroGuia = 012, fechaImposicion = new DateTime(2026, 04, 16), CDorigen = "Córdoba", CDdestino = "Mendoza", tamaño = "L", importe = 15000 , estadoGuia="Impuesta", tipoEntrega = "D", tipoImposicion = "A"},
            new GuiasAAdmitir { Id = 13, clienteID = 3, numeroGuia = 013, fechaImposicion = new DateTime(2026, 04, 17), CDorigen = "La Plata", CDdestino = "Mar del Plata", tamaño = "M", importe = 10000, estadoGuia="Impuesta", tipoImposicion = "C", tipoEntrega ="D" },
            new GuiasAAdmitir { Id = 14, clienteID = 4, numeroGuia = 014, fechaImposicion = new DateTime(2026, 04, 18), CDorigen = "San Juan", CDdestino = "Salta", tamaño = "S", importe = 6000, estadoGuia="Impuesta", tipoImposicion = "A", tipoEntrega="D"},
            new GuiasAAdmitir { Id = 15, clienteID = 1, numeroGuia = 015, fechaImposicion = new DateTime(2026, 04, 19), CDorigen = "Neuquén", CDdestino = "Bahía Blanca", tamaño = "XL", importe = 20000, estadoGuia="Impuesta", tipoImposicion="C", tipoEntrega="A" },
            new GuiasAAdmitir { Id = 16, clienteID = 2, numeroGuia = 016, fechaImposicion = new DateTime(2026, 04, 20), CDorigen = "Tucumán", CDdestino = "Santa Fe", tamaño = "L", importe = 14000, estadoGuia="Impuesta", tipoImposicion="A", tipoEntrega="D" },
            new GuiasAAdmitir { Id = 17, clienteID = 3, numeroGuia = 017, fechaImposicion = new DateTime(2026, 04, 21), CDorigen = "Corrientes", CDdestino = "Posadas", tamaño = "M", importe = 11000, estadoGuia="Impuesta", tipoImposicion="C", tipoEntrega="C" },
            new GuiasAAdmitir { Id = 18, clienteID = 4, numeroGuia = 018, fechaImposicion = new DateTime(2026, 04, 22), CDorigen = "Resistencia", CDdestino = "San Luis", tamaño = "S", importe = 7000, estadoGuia="Impuesta", tipoImposicion="A", tipoEntrega="D" },
            new GuiasAAdmitir { Id = 19, clienteID = 5, numeroGuia = 019, fechaImposicion = new DateTime(2026, 04, 23), CDorigen = "Catamarca", CDdestino = "Jujuy", tamaño = "XL", importe = 19000, estadoGuia="Impuesta", tipoImposicion="C", tipoEntrega="A" },
            new GuiasAAdmitir { Id = 20, clienteID = 1, numeroGuia = 020, fechaImposicion = new DateTime(2026, 04, 24), CDorigen = "Buenos Aires", CDdestino = "San Luis", tamaño = "L", importe = 13000, estadoGuia="Impuesta", tipoImposicion="C", tipoEntrega="D" }
        };

        
        public List<Cajas> LCajas => new List<Cajas>
        {
            new Cajas { ID = 1, nombre = "S" },
            new Cajas { ID = 2, nombre = "M" },
            new Cajas { ID = 3, nombre = "L" },
            new Cajas { ID = 4, nombre = "XL" }
        };
        public List<TarifaCliente> LTarifaCliente => new List<TarifaCliente>
        {
            new TarifaCliente { Id = 1, clienteID = 1, descuentoxKm = 0.10m },
            new TarifaCliente { Id = 2, clienteID = 2, descuentoxKm = 0.11m },
            new TarifaCliente { Id = 3, clienteID = 3, descuentoxKm = 0.15m },
            new TarifaCliente { Id = 4, clienteID = 4, descuentoxKm = 0.18m },
            new TarifaCliente { Id = 5, clienteID = 5, descuentoxKm = 0.08m },
            new TarifaCliente { Id = 6, clienteID = 6, descuentoxKm = 0.12m },
            new TarifaCliente { Id = 7, clienteID = 7, descuentoxKm = 0.10m },
            new TarifaCliente { Id = 8, clienteID = 8, descuentoxKm = 0.07m },
            new TarifaCliente { Id = 9, clienteID = 9, descuentoxKm = 0.05m },
            new TarifaCliente { Id = 10, clienteID = 10, descuentoxKm = 0.0m },
        };

    }
}
