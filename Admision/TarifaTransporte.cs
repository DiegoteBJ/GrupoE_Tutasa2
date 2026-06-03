using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace GrupoE_Tutasa.Admision
{
    internal class TarifaTransporte
    {
        public int CDOrigenId { get; set; }
        public int CDDestinoId { get; set; }
        public decimal CoeficienteS { get; set; }
        public decimal CoeficienteM { get; set; }
        public decimal CoeficienteL { get; set; }
        public decimal CoeficienteXL { get; set; }
    }
}
