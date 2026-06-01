using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.EntregaEnCD
{
    public class EntregaEnCDModelo
    {
        private List<Guia> guias = new List<Guia>
        {
            new Guia
            {
                GuiaId = 1001,
                DniDestinatario = 30111222,
                NombreDestinatario = "Maria",
                ApellidoDestinatario = "Gomez",
                Tamanio = "M",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "CD Buenos Aires"
            },

            new Guia
            {
                GuiaId = 1002,
                DniDestinatario = 30111222,
                NombreDestinatario = "Maria",
                ApellidoDestinatario = "Gomez",
                Tamanio = "L",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "CD Cordoba"
            },

            new Guia
            {
                GuiaId = 1003,
                DniDestinatario = 28999888,
                NombreDestinatario = "Carlos",
                ApellidoDestinatario = "Perez",
                Tamanio = "S",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "CD Rosario"
            },

            new Guia
            {
                GuiaId = 1004,
                DniDestinatario = 33444555,
                NombreDestinatario = "Lucia",
                ApellidoDestinatario = "Fernandez",
                Tamanio = "XL",
                Estado = "ENTREGADA",
                UbicacionActual = "CD Buenos Aires"
            }
        };

        public List<Guia> BuscarGuiasPendientesEnCD(long dni)
        {
            return guias
                .Where(g => g.DniDestinatario == dni
                         && g.Estado == "PENDIENTE_DE_ENTREGA"
                         && g.UbicacionActual.Contains("CD"))
                .ToList();
        }

        public Guia BuscarGuiaPorDni(long dni)
        {
            return guias.FirstOrDefault(g => g.DniDestinatario == dni);
        }

        public void ConfirmarEntrega(int guiaId)
        {
            Guia guia = guias.FirstOrDefault(g => g.GuiaId == guiaId);

            if (guia != null)
            {
                guia.Estado = "ENTREGADA";
            }
        }
    }
}