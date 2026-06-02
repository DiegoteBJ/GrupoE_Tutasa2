using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Admision
{
    internal class Tarifario
    {
        public int TarifarioId { get; set; }
        public decimal TarifaImposicionAgencia { get; set; }
        public decimal TarifaRetiroDomicilio { get; set; }
        public decimal TarifaEntregaAgencia { get; set; }
        public decimal TarifaDistribucionDomicilio { get; set; }
        public decimal TarifaUnitarioTransporte { get; set; }
    }
}
