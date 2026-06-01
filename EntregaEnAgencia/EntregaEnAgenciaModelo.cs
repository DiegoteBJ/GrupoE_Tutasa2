using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.EntregaEnAgencia
{
    public class EntregaEnAgenciaModelo
    {
        private List<Guia> guias = new List<Guia>
        {
            new Guia
            {
                GuiaId = 2001,
                DniDestinatario = 30111222,
                NombreDestinatario = "Maria",
                ApellidoDestinatario = "Gomez",
                Tamanio = "M",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "Agencia Moron"
            },
            new Guia
            {
                GuiaId = 2002,
                DniDestinatario = 30111222,
                NombreDestinatario = "Maria",
                ApellidoDestinatario = "Gomez",
                Tamanio = "L",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "Agencia Ramos Mejia"
            },
            new Guia
            {
                GuiaId = 2003,
                DniDestinatario = 28999888,
                NombreDestinatario = "Carlos",
                ApellidoDestinatario = "Perez",
                Tamanio = "S",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "Agencia Liniers"
            },
            new Guia
            {
                GuiaId = 2004,
                DniDestinatario = 33444555,
                NombreDestinatario = "Lucia",
                ApellidoDestinatario = "Fernandez",
                Tamanio = "XL",
                Estado = "ENTREGADA",
                UbicacionActual = "Agencia Moron"
            }
        };

        public List<Guia> BuscarGuiasPendientesEnAgencia(long dni)
        {
            return guias
                .Where(g => g.DniDestinatario == dni
                         && g.Estado == "PENDIENTE_DE_ENTREGA"
                         && g.UbicacionActual.Contains("Agencia"))
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
                guia.Estado = "ENTREGADA";
        }
    }
}