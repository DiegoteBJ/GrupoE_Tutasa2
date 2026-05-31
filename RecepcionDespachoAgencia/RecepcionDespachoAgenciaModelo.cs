using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RecepcionDespachoAgencia
{
    internal class RecepcionDespachoAgenciaModelo
    {
        // Lista de fleteros
        private List<Fletero> fleteros = new()
        {
            new Fletero
            {
                fleteroDNI = 12345678,
                fleteroNombre = "Juan",
                fleteroApellido = "Perez"
            },
            new Fletero
            {
                fleteroDNI = 30555444,
                fleteroNombre = "Carlos",
                fleteroApellido = "Lopez"
            }
        };
        public List<Fletero> LFleteros => fleteros;

        // Lista de HDR Retiro
        private List<HDRRetiro> hdrRetiro = new()
        {
            new HDRRetiro
            {
                numeroHDR = "HDR-20250504-018",
                fleteroDNI = 12345678,
                estadoHDR = "Pendiente"
            },
            new HDRRetiro
            {
                numeroHDR = "HDR-20250504-019",
                fleteroDNI = 12345678,
                estadoHDR = "Pendiente"
            }
        };
        public List<HDRRetiro> LHDRRetiro => hdrRetiro;

        // Lista de HDR Distribución
        private List<HDRDistribucion> hdrDistribucion = new()
        {
            new HDRDistribucion
            {
                numeroHDR = "HDR-20250504-020",
                fleteroDNI = 12345678,
                estadoHDR = "Pendiente"
            }
        };
        public List<HDRDistribucion> LHDRDistribucion => hdrDistribucion;

        // Lista de Guías
        private List<Guia> guias = new()
        {
            new Guia
            {
                guiaId = 1001,
                numeroHDR = "HDR-20250504-018",
                tipo = "XL",
                estado = "Pendiente"
            },
            new Guia
            {
                guiaId = 1002,
                numeroHDR = "HDR-20250504-018",
                tipo = "M",
                estado = "Pendiente"
            },
            new Guia
            {
                guiaId = 1003,
                numeroHDR = "HDR-20250504-020",
                tipo = "S",
                estado = "Pendiente"
            }
        };
        public List<Guia> LGuias => guias;
    }

}

