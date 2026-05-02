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
                    new GuiasPendientes { Id = 1, clienteID=1, numeroGuia = "G001", fechaAdmision = DateTime.Now.AddDays(-5), origen = "Ciudad A", destino = "Ciudad B", tamaño = "Grande", importe = 15000 },
                    new GuiasPendientes { Id = 2, clienteID=1, numeroGuia = "G002", fechaAdmision = DateTime.Now.AddDays(-3), origen = "Ciudad C", destino = "Ciudad D", tamaño = "Mediano", importe = 10000 },
                    new GuiasPendientes { Id = 3, clienteID=2, numeroGuia = "G003", fechaAdmision = DateTime.Now.AddDays(-1), origen = "Ciudad E", destino = "Ciudad F", tamaño = "Pequeño", importe = 5000 },
                    new GuiasPendientes { Id = 4, clienteID=3, numeroGuia = "G004", fechaAdmision = DateTime.Now.AddDays(-2), origen = "Ciudad G", destino = "Ciudad H", tamaño = "Grande", importe = 20000 }
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
                    new Clientes { clienteId = 4, clienteName = "Cliente D", clienteCUIT = 20483900342 }
                };
            }
        }
    }
}
