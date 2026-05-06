using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EmitirFactura
{
    internal class EmisionFacturaModelo
    {
        public List<GuiasPendientes> LGuiasPendientes  
        {
            get
            {
                return new List<GuiasPendientes>
                {
                    new GuiasPendientes { Id = 1, clienteID = 1, numeroGuia = "G001", fechaAdmision = new DateTime(2026, 01, 05), origen = "Buenos Aires", destino = "Rosario", tamaño = "L", importe = 15000 },
                    new GuiasPendientes { Id = 2, clienteID = 2, numeroGuia = "G002", fechaAdmision = new DateTime(2026, 01, 06), origen = "Córdoba", destino = "Mendoza", tamaño = "M", importe = 10000 },
                    new GuiasPendientes { Id = 3, clienteID = 3, numeroGuia = "G003", fechaAdmision = new DateTime(2026, 01, 07), origen = "La Plata", destino = "Mar del Plata", tamaño = "S", importe = 6000 },
                    new GuiasPendientes { Id = 4, clienteID = 4, numeroGuia = "G004", fechaAdmision = new DateTime(2026, 01, 08), origen = "San Juan", destino = "Salta", tamaño = "XL", importe = 20000 },
                    new GuiasPendientes { Id = 5, clienteID = 5, numeroGuia = "G005", fechaAdmision = new DateTime(2026, 01, 09), origen = "Neuquén", destino = "Bahía Blanca", tamaño = "M", importe = 11000 },
                    new GuiasPendientes { Id = 6, clienteID = 6, numeroGuia = "G006", fechaAdmision = new DateTime(2026, 01, 10), origen = "Tucumán", destino = "Santa Fe", tamaño = "S", importe = 7000 },
                    new GuiasPendientes { Id = 7, clienteID = 1, numeroGuia = "G007", fechaAdmision = new DateTime(2026, 01, 11), origen = "Corrientes", destino = "Posadas", tamaño = "XL", importe = 19000 },
                    new GuiasPendientes { Id = 8, clienteID = 2, numeroGuia = "G008", fechaAdmision = new DateTime(2026, 01, 12), origen = "Resistencia", destino = "San Luis", tamaño = "L", importe = 14000 },
                    new GuiasPendientes { Id = 9, clienteID = 3, numeroGuia = "G009", fechaAdmision = new DateTime(2026, 01, 13), origen = "Catamarca", destino = "Jujuy", tamaño = "M", importe = 9500 },
                    new GuiasPendientes { Id = 10, clienteID = 4, numeroGuia = "G010", fechaAdmision = new DateTime(2026, 01, 14), origen = "Trelew", destino = "Río Gallegos", tamaño = "S", importe = 7500 },
                    new GuiasPendientes { Id = 11, clienteID = 1, numeroGuia = "G011", fechaAdmision = new DateTime(2026, 01, 15), origen = "Buenos Aires", destino = "Rosario", tamaño = "XL", importe = 20000 },
                    new GuiasPendientes { Id = 12, clienteID = 2, numeroGuia = "G012", fechaAdmision = new DateTime(2026, 01, 16), origen = "Córdoba", destino = "Mendoza", tamaño = "L", importe = 15000 },
                    new GuiasPendientes { Id = 13, clienteID = 3, numeroGuia = "G013", fechaAdmision = new DateTime(2026, 01, 17), origen = "La Plata", destino = "Mar del Plata", tamaño = "M", importe = 10000 },
                    new GuiasPendientes { Id = 14, clienteID = 4, numeroGuia = "G014", fechaAdmision = new DateTime(2026, 01, 18), origen = "San Juan", destino = "Salta", tamaño = "S", importe = 6000 },
                    new GuiasPendientes { Id = 15, clienteID = 1, numeroGuia = "G015", fechaAdmision = new DateTime(2026, 01, 19), origen = "Neuquén", destino = "Bahía Blanca", tamaño = "XL", importe = 20000 },
                    new GuiasPendientes { Id = 16, clienteID = 2, numeroGuia = "G016", fechaAdmision = new DateTime(2026, 01, 20), origen = "Tucumán", destino = "Santa Fe", tamaño = "L", importe = 14000 },
                    new GuiasPendientes { Id = 17, clienteID = 3, numeroGuia = "G017", fechaAdmision = new DateTime(2026, 01, 21), origen = "Corrientes", destino = "Posadas", tamaño = "M", importe = 11000 },
                    new GuiasPendientes { Id = 18, clienteID = 4, numeroGuia = "G018", fechaAdmision = new DateTime(2026, 01, 22), origen = "Resistencia", destino = "San Luis", tamaño = "S", importe = 7000 },
                    new GuiasPendientes { Id = 19, clienteID = 5, numeroGuia = "G019", fechaAdmision = new DateTime(2026, 01, 23), origen = "Catamarca", destino = "Jujuy", tamaño = "XL", importe = 19000 },
                    new GuiasPendientes { Id = 20, clienteID = 1, numeroGuia = "G020", fechaAdmision = new DateTime(2026, 01, 24), origen = "Trelew", destino = "Río Gallegos", tamaño = "L", importe = 15000 },
                };
            }
        }
        public List<Clientes> LClientes
        {
            get
            {
                return new List<Clientes>
                {
                    new Clientes { clienteId = 1, clienteName = "Cliente A", clienteCUIT = 30654364229 },
                    new Clientes { clienteId = 2, clienteName = "Cliente B", clienteCUIT = 27202016494 },
                    new Clientes { clienteId = 3, clienteName = "Cliente C", clienteCUIT = 20483900334 },
                    new Clientes { clienteId = 4, clienteName = "Cliente D", clienteCUIT = 20483900342 },
                    new Clientes { clienteId = 5, clienteName = "Cliente E", clienteCUIT = 20329642330 },
                    new Clientes { clienteId = 6, clienteName = "Cliente F", clienteCUIT = 27384592017 },
                    new Clientes { clienteId = 7, clienteName = "Cliente G", clienteCUIT = 30765432109 },
                    new Clientes { clienteId = 8, clienteName = "Cliente H", clienteCUIT = 23345678903 },
                    new Clientes { clienteId = 9, clienteName = "Cliente I", clienteCUIT = 30789123456 },
                    new Clientes { clienteId = 10, clienteName = "Cliente J", clienteCUIT = 20345678901 },
                };
            }
        }
    }
}
