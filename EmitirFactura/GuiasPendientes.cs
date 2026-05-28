using System;
using System.Collections.Generic;
using System.Text;
// Esta clase representa las guías que tienen estado de entregadas y pendientes de emisión de factura, con sus propiedades correspondientes.

namespace GrupoE_Tutasa.EmitirFactura
{
    internal class GuiasPendientes
    {
        public int Id { get; set; }
        public int clienteID { get; set; }
        public int numeroGuia { get; set; }
        public DateTime fechaAdmision { get; set; }
        public string origen { get; set; } = string.Empty;
        public string destino { get; set; } = string.Empty;
        public string modalidadImposicion { get; set; } = string.Empty;
        public string modalidadEntrega { get; set; } = string.Empty;
        public string tamaño { get; set; } = string.Empty;
        public decimal importe { get; set; }
    }
}
