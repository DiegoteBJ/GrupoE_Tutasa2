using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EmitirFactura
{
    internal class EmisionFacturaModelo
    {
        public List<GuiasPendientesFacturar> GuiasPendiente
        {
            get
            {
                return new List<GuiasPendientesFacturar>
                {
                    new GuiasPendientesFacturar { Id = 1, clienteID=1, numeroGuia = "G001", fechaAdmision = DateTime.Now.AddDays(-5), origen = "Ciudad A", destino = "Ciudad B", tamaño = "Grande", importe = 15000 },
                    new GuiasPendientesFacturar { Id = 2, clienteID=1, numeroGuia = "G002", fechaAdmision = DateTime.Now.AddDays(-3), origen = "Ciudad C", destino = "Ciudad D", tamaño = "Mediano", importe = 10000 },
                    new GuiasPendientesFacturar { Id = 3, clienteID=2, numeroGuia = "G003", fechaAdmision = DateTime.Now.AddDays(-1), origen = "Ciudad E", destino = "Ciudad F", tamaño = "Pequeño", importe = 5000 },
                    new GuiasPendientesFacturar { Id = 4, clienteID=3, numeroGuia = "G004", fechaAdmision = DateTime.Now.AddDays(-2), origen = "Ciudad G", destino = "Ciudad H", tamaño = "Grande", importe = 20000 }
                };
            }
        }
        public List<Cliente> ClienteFacturar
        {
            get
            {
                return new List<Cliente>
                {
                    new Cliente { clienteId = 1, clienteName = "Cliente A", clienteCUIT = 12345678901 },
                    new Cliente { clienteId = 2, clienteName = "Cliente B", clienteCUIT = 23456789012 },
                    new Cliente { clienteId = 3, clienteName = "Cliente C", clienteCUIT = 34567890123 },
                    new Cliente { clienteId = 4, clienteName = "Cliente D", clienteCUIT = 45678901234 }
                };
            }
        }
    }
}
