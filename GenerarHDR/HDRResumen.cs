using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class HDRResumen
    {
        public int HDRId { get; set; }
        public int GuiaId { get; set; }
        public string Destinatario { get; set; }
        public string Domicilio { get; set; }
        public string CodigoPostal { get; set; }
        public string TipoHDR { get; set; } // Retiro o Distribución
    

    public HDRResumen(int hdrId, GuiasAAsignar guia, string tipo)
        {
            HDRId = hdrId;
            GuiaId = guia.GuiaId;
            Destinatario = guia.NombreDestinatarioGuia;
            Domicilio = guia.DomicilioGuia;
            CodigoPostal = guia.CodigoPostalGuia;
            TipoHDR = tipo;
        }
    }
}
