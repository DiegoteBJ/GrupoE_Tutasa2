using System;
using System.Collections.Generic;
using System.Text;
using GrupoE_Tutasa.Almacenes;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class HDRResumen
    {
        public int HDRId { get; set; }                // correlativo interno, no persistente
        public List<int> GuiasIds { get; set; } = new List<int>(); // ✅ lista de guías
        public string Destinatario { get; set; }
        public string Domicilio { get; set; }
        public string CodigoPostal { get; set; }
        public string TipoHDR { get; set; }           // Retiro o Distribución
        public int IntentosDeEntrega { get; set; }
        public List<int> GuiasAImprimir { get; set; } = new List<int>(); // guías impuestas telefónicamente
        public DateTime FechaImpresion { get; set; }  // fecha/hora de impresión

        // ✅ Constructor principal: recibe lista de guías y tipo de HDR
        public HDRResumen(int hdrId, List<GuiaEntidad> guias, string tipoHDR)
        {
            HDRId = hdrId;
            GuiasIds = guias.Select(g => g.GuiaId).ToList();
            Destinatario = string.Join(", ", guias.Select(g => g.NombreDestinatario));
            TipoHDR = tipoHDR;

            if (tipoHDR == "Retiro")
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

            // ✅ Intentos máximos de entrega en el grupo
            IntentosDeEntrega = guias.Max(g => g.IntentosDeEntrega);

            // ✅ Fecha/hora de impresión
            FechaImpresion = DateTime.Now;
        }
    }
}
    

