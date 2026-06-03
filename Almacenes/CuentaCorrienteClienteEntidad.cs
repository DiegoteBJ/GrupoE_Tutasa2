using System;

namespace GrupoE_Tutasa.Almacenes
{
    public class CuentaCorrienteClienteEntidad
    {
        public int CcClienteId { get; set; }
        public int ClienteId { get; set; }
        public int GuiaId { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal PrecioImposicion { get; set; }
        public decimal PrecioTransporte { get; set; }
        public decimal PrecioEntrega { get; set; }
        public decimal PrecioCalculadoTotal { get; set; }
        public int EmpresaTransporteId { get; set; }
        public bool Facturado { get; set; }
        public int DocumentoId { get; set; }
    }
}
