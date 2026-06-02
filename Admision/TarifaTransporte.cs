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
        public int CoeficienteS { get; set; }
        public int CoeficienteM { get; set; }
        public int CoeficienteL { get; set; }
        public int CoeficienteXL { get; set; }
    }
}
