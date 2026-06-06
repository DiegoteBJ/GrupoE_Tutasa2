using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDRTransporte
{
        public class ServicioTransporte
        {
            public string ServicioId { get; set; }
            public string NombreEmpresa { get; set; }
            public DateTime FechaEmision { get; set; }
            public DateTime FechaHoraSalida { get; set; }   // nueva
            public string Ruta { get; set; }
            public List<Guia> GuiasPendientes { get; set; } = new();
        }
    }


