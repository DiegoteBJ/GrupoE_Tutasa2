using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class HDRResumen
    {
        public int HDRId { get; set; }
        public int GuiaId { get; set; } // opcional: primer guía, útil para compatibilidad
        public List<int> GuiasIds { get; set; } = new List<int>(); // ✅ lista de guías
        public string Destinatario { get; set; }
        public string Domicilio { get; set; }
        public string CodigoPostal { get; set; }
        public string TipoHDR { get; set; } // Retiro o Distribución
        public int IntentosDeEntrega { get; set; }


        // Constructor para varias guías (agrupadas por domicilio)
        public HDRResumen(int hdrId, List<Guias> guias, string tipo)
        {
            HDRId = hdrId;
            GuiasIds = guias.Select(g => g.GuiaId).ToList();
            GuiaId = GuiasIds.FirstOrDefault(); // opcional, primer guía
            Destinatario = string.Join(", ", guias.Select(g => g.NombreDestinatarioGuia));
            TipoHDR = tipo;

            if (tipo == "Retiro")
            {
                var domicilio = guias.First().DomicilioRetiro;
                Domicilio = $"{domicilio.Calle} {domicilio.Numero}";
                CodigoPostal = domicilio.CodigoPostal;
            }
            else // Distribución
            {
                var domicilio = guias.First().DomicilioEntrega;
                Domicilio = $"{domicilio.Calle} {domicilio.Numero}";
                CodigoPostal = domicilio.CodigoPostal;
            }

            // Si hay varias guías, tomás el máximo de intentos de entrega
            IntentosDeEntrega = guias.Max(g => g.IntentosDeEntrega);
        }
    }
}
