using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.MonitoreoResultados
{
    internal class ConvenioTransporte
    {
        public int ConvenioId { get; set; }
        public int EmpresaTransporteId { get; set; }
        public DateTime FechaVigenciaDesde { get; set; }
        public DateTime FechaVigenciaHasta { get; set; }
        public Decimal ImporteConvenio { get; set; }
        
        
    }
}
