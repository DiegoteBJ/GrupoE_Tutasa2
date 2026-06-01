using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.RecepcionDespachoCDLargaDistancia
{

    internal class ServicioTransporte
    {
        public string ServicioId { get; set; }
        public string NombreEmpresa { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Ruta { get; set; }
        public List<HDRTransporte> HDRsARecibir { get; set; }
        public List<HDRTransporte> HDRsADespachar { get; set; }
    }
}

