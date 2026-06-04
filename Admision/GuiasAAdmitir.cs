using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Admision
{
    internal class GuiasAAdmitir
    {
        public int Id { get; set; }
        public int clienteID { get; set; }
        public int numeroGuia { get; set; } 
        public DateTime fechaImposicion { get; set; }
        public DateTime fechaAdmision { get; set; }
        public int CDOrigenId { get; set; } 
        public int CDDestinoId { get; set; } 
        public string tamaño { get; set; } = string.Empty;
        public decimal importeImposicion { get; set; }
        public decimal importeEntrega { get; set; }
        public decimal importeTransporte { get; set; }
        public decimal importe { get; set; }
        public string estadoGuia { get; set; }
        public string observaciones { get; set; }
        public string tipoImposicion { get; set; }
        public string tipoEntrega { get; set; }
        public int tarifarioId { get; set; }
    }
}
