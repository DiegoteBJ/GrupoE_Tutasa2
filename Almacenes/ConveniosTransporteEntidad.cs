using System;

namespace GrupoE_Tutasa.Almacenes
{
    public class ConveniosTransporteEntidad
    {
        public int ConvenioId { get; set; }
        public int EmpresaTransporteId { get; set; }
        public DateTime FechaVigenciaDesde { get; set; }
        public DateTime FechaVigenciaHasta { get; set; }
        public decimal ImporteConvenio { get; set; }
    }
}
