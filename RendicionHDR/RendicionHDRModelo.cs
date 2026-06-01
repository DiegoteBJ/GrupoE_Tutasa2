using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RendicionHDR
{
    internal class RendicionHDRModelo
    {
        private List<Fletero> fleteros = new()
    {
        new Fletero
        {
            fleteroDNI = 12345678,
            fleteroNombre = "Juan",
            fleteroApellido = "Perez"
        }
    };
        public List<Fletero> LFleteros => fleteros;

        private List<HDRRetiro> hdrRetiro = new()
    {
        new HDRRetiro
        {
            numeroHDR = "1001",
            fleteroDNI = 12345678,
            estadoHDR = "Pendiente",
            fechaHDR = DateTime.Today
        }
    };
        public List<HDRRetiro> LHDRRetiro => hdrRetiro;

        private List<HDRDistribucion> hdrDistribucion = new()
    {
        new HDRDistribucion
        {
            numeroHDR = "2001",
            fleteroDNI = 12345678,
            estadoHDR = "Pendiente",
            fechaHDR = DateTime.Today
        }
    };
        public List<HDRDistribucion> LHDRDistribucion => hdrDistribucion;

        private List<Guia> guias = new()
{
        new Guia
    {
        guiaId = 10001,
        numeroHDR = "1001",
        remitente = "Juan Gomez",
        destinatario = "Maria Lopez",
        domicilio = "Av. Rivadavia 123",
        tamanio = "M",
        intentosEntrega = 0,
        resultado = "Pendiente"
    },
        new Guia
    {
        guiaId = 10002,
        numeroHDR = "1001",
        remitente = "Pedro Diaz",
        destinatario = "Ana Perez",
        domicilio = "Sarmiento 456",
        tamanio = "XL",
        intentosEntrega = 1,
        resultado = "Pendiente"
    },
        new Guia
    {
        guiaId = 20001,
        numeroHDR = "2001",
        remitente = "Carlos Gomez",
        destinatario = "Laura Perez",
        domicilio = "Belgrano 123",
        tamanio = "S",
        intentosEntrega = 0,
        resultado = "Pendiente"
    },
        new Guia
    {
        guiaId = 20002,
        numeroHDR = "2001",
        remitente = "Miguel Diaz",
        destinatario = "Sofia Lopez",
        domicilio = "Mitre 456",
        tamanio = "L",
        intentosEntrega = 1,
        resultado = "Pendiente"
    }
};
        public List<Guia> LGuias => guias;
    }

}
