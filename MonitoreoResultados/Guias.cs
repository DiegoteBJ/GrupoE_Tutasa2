using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.MonitoreoResultados
{
    internal class Guias
    {
    // Esta clase representa las guías que tienen estado de entregadas y facturadas, con sus propiedades correspondientes.
        public int Id { get; set; }
        public int clienteID { get; set; }
        public string numeroGuia { get; set; } = string.Empty;
        public DateTime fechaAdmision { get; set; }
        public string origen { get; set; } = string.Empty;
        public string destino { get; set; } = string.Empty;
        public string modalidadImposicion { get; set; } = string.Empty;
        public string modalidadEntrega { get; set; } = string.Empty;
        public string tamaño { get; set; } = string.Empty;
        public decimal importe { get; set; }
    }
}