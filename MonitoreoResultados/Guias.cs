using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.MonitoreoResultados
{
    internal class Guias
    {
        // Esta clase representa las guías que tienen estado de entregadas y facturadas.
        // Por las modificaciones que se hicieron en el diagrama de clases, surge en realidad de la clase CuentaCorriente
        // que almacena los datos de las guias a partir de la admision de cada encomienda y almacena estos datos.
        // para que esté entregada y facturada debe tener: facturada = true, fechaEntrega != null y documentoId != 0


        public int clienteID { get; set; }
        public int numeroGuia { get; set; } 
        public DateTime fechaMovimiento { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int proveedorTransporteId { get; set; }
        public decimal importeImposicion { get; set; }
        public decimal importeEntrega { get; set; }
        public decimal importeTransporte { get; set; }
        public decimal importeTotal { get; set; }
        public bool facturada { get; set; }
        public int documentoId { get; set; }
    }
}