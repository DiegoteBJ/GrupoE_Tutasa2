using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.EntregaEnAgencia
{
    internal class EntregaEnAgenciaModelo
    {
        private List<Destinatario> destinatarios = new List<Destinatario>
        {
            new Destinatario
            {
                DestinatarioId = 1,
                Dni = 30111222,
                Nombre = "Maria",
                Apellido = "Gomez"
            },

            new Destinatario
            {
                DestinatarioId = 2,
                Dni = 28999888,
                Nombre = "Carlos",
                Apellido = "Perez"
            }
        };

        private List<Guia> guias = new List<Guia>
        {
            new Guia
            {
                GuiaId = 2001,
                DestinatarioId = 1,
                Tamanio = "M",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "Agencia Moron"
            },

            new Guia
            {
                GuiaId = 2002,
                DestinatarioId = 1,
                Tamanio = "L",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "Agencia Ramos Mejia"
            },

            new Guia
            {
                GuiaId = 2003,
                DestinatarioId = 2,
                Tamanio = "S",
                Estado = "PENDIENTE_DE_ENTREGA",
                UbicacionActual = "Agencia Liniers"
            }
        };

        public Destinatario BuscarDestinatarioPorDni(long dni)
        {
            return destinatarios.FirstOrDefault(d => d.Dni == dni);
        }

        public List<Guia> BuscarGuiasPendientesEnAgencia(long dni)
        {
            Destinatario destinatario = BuscarDestinatarioPorDni(dni);

            if (destinatario == null)
                return new List<Guia>();

            return guias
                .Where(g => g.DestinatarioId == destinatario.DestinatarioId
                         && g.Estado == "PENDIENTE_DE_ENTREGA"
                         && g.UbicacionActual.Contains("Agencia"))
                .ToList();
        }

        public void ConfirmarEntrega(int guiaId)
        {
            Guia guia = guias.FirstOrDefault(g => g.GuiaId == guiaId);

            if (guia != null)
                guia.Estado = "ENTREGADA";
        }
    }
}