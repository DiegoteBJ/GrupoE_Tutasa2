using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RecepcionDespachoCDLargaDistancia
{
    internal class HDRTransporte
    {
        public int HdrTransporteId { get; set; }
        public string NroGuia { get; set; }
        public string Destino { get; set; }
        public string Tamaño { get; set; }   // "S", "M", "L", "XL"
        public string Estado { get; set; }    // "Pendiente", "EnTransito", "Recibida"
    }
}
