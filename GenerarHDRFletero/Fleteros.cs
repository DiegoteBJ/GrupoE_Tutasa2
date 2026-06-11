using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal class Fleteros
    {

        public int FleteroId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Cuit { get; set; }
        public decimal CostoPorBulto_S { get; set; }
        public decimal CostoPorBulto_M { get; set; }
        public decimal CostoPorBulto_L { get; set; }
        public decimal CostoPorBulto_XL { get; set; }
        public List<string> CodigosPostalesCobertura { get; set; }
    }
}
