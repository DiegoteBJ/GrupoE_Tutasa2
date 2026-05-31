using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrupoE_Tutasa.EntregaEnCD
{
    public class EntregaEnCDModelo
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
    },

    new Destinatario
    {
        DestinatarioId = 3,
        Dni = 33444555,
        Nombre = "Lucia",
        Apellido = "Fernandez"
    },

    new Destinatario
    {
        DestinatarioId = 4,
        Dni = 40123456,
        Nombre = "Martin",
        Apellido = "Lopez"
    },

    new Destinatario
    {
        DestinatarioId = 5,
        Dni = 27888999,
        Nombre = "Ana",
        Apellido = "Suarez"
    },

    new Destinatario
    {
        DestinatarioId = 6,
        Dni = 35666777,
        Nombre = "Javier",
        Apellido = "Torres"
    }
};

        private List<Guia> guias = new List<Guia>
{
    new Guia
    {
        GuiaId = 1001,
        DestinatarioId = 1,
        Tamanio = "M",
        Estado = "PENDIENTE_DE_ENTREGA",
        UbicacionActual = "CD Buenos Aires"
    },

    new Guia
    {
        GuiaId = 1002,
        DestinatarioId = 1,
        Tamanio = "L",
        Estado = "PENDIENTE_DE_ENTREGA",
        UbicacionActual = "CD Cordoba"
    },

    new Guia
    {
        GuiaId = 1003,
        DestinatarioId = 2,
        Tamanio = "S",
        Estado = "PENDIENTE_DE_ENTREGA",
        UbicacionActual = "CD Rosario"
    },

    new Guia
    {
        GuiaId = 1004,
        DestinatarioId = 3,
        Tamanio = "XL",
        Estado = "ENTREGADA",
        UbicacionActual = "CD Buenos Aires"
    },

    new Guia
    {
        GuiaId = 1005,
        DestinatarioId = 4,
        Tamanio = "M",
        Estado = "EN_TRANSITO",
        UbicacionActual = "Ruta 9"
    },

    new Guia
    {
        GuiaId = 1006,
        DestinatarioId = 5,
        Tamanio = "L",
        Estado = "PENDIENTE_DE_ENTREGA",
        UbicacionActual = "Agencia Moron"
    },

    new Guia
    {
        GuiaId = 1007,
        DestinatarioId = 6,
        Tamanio = "S",
        Estado = "PENDIENTE_DE_ENTREGA",
        UbicacionActual = "CD Mendoza"
    }
};
        public Destinatario BuscarDestinatarioPorDni(long dni)
        {
            return destinatarios.FirstOrDefault(d => d.Dni == dni);
        }

        public List<Guia> BuscarGuiasPendientesEnCD(long dni)
        {
            Destinatario destinatario = BuscarDestinatarioPorDni(dni);

            if (destinatario == null)
            {
                return new List<Guia>();
            }

            return guias
                .Where(g => g.DestinatarioId == destinatario.DestinatarioId
                         && g.Estado == "PENDIENTE_DE_ENTREGA"
                         && g.UbicacionActual.Contains("CD"))
                .ToList();
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