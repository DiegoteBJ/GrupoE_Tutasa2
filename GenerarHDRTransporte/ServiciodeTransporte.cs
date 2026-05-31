using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDRTransporte
{
        public class ServicioTransporte
        {
            public string ServicioId { get; set; }
            public string NombreEmpresa { get; set; }
            public DateTime FechaSalida { get; set; }
            public string Ruta { get; set; }
            public List<Guia> GuiasPendientes { get; set; } = new();
        }
    }


