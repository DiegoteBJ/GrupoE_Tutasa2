using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Admision
{
    internal class GuiasAImponer
    {
        public int Id { get; set; }
        public int clienteID { get; set; }
        public string numeroGuia { get; set; } = string.Empty;
        public DateTime fechaImposicion { get; set; }
        public DateTime fechaAdmision { get; set; }
        public string CDorigen { get; set; } = string.Empty;
        public string CDdestino { get; set; } = string.Empty;
        public string tamaño { get; set; } = string.Empty;
        public decimal importe { get; set; }
        public string estadoGuia { get; set; }
        public string observaciones { get; set; }
    }
}
