using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.EmitirFactura;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.Admision
{
    internal class AdmisionModelo
    {
        public List<GuiasAAdmitir> LGuiasAAdmitir => new List<GuiasAAdmitir>
        {
            new GuiasAAdmitir { Id = 1,  clienteID = 1, numeroGuia = 001, fechaImposicion = new DateTime(2026, 04, 05), CDOrigenId = 1,  CDDestinoId = 2,  tamaño = "L",  estadoGuia = "RENDIDA",  tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 2,  clienteID = 2, numeroGuia = 002, fechaImposicion = new DateTime(2026, 04, 06), CDOrigenId = 3,  CDDestinoId = 4,  tamaño = "M",  estadoGuia = "RENDIDA",  tipoImposicion = "C", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 3,  clienteID = 3, numeroGuia = 003, fechaImposicion = new DateTime(2026, 04, 07), CDOrigenId = 5,  CDDestinoId = 6,  tamaño = "S",  estadoGuia = "RENDIDA",  tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 4,  clienteID = 4, numeroGuia = 004, fechaImposicion = new DateTime(2026, 04, 08), CDOrigenId = 7,  CDDestinoId = 8,  tamaño = "XL", estadoGuia = "RENDIDA",  tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 5,  clienteID = 5, numeroGuia = 005, fechaImposicion = new DateTime(2026, 04, 09), CDOrigenId = 9,  CDDestinoId = 10, tamaño = "M",  estadoGuia = "ADMITIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 6,  clienteID = 6, numeroGuia = 006, fechaImposicion = new DateTime(2026, 04, 10), CDOrigenId = 11, CDDestinoId = 12, tamaño = "S",  estadoGuia = "RENDIDA",  tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 7,  clienteID = 1, numeroGuia = 007, fechaImposicion = new DateTime(2026, 04, 11), CDOrigenId = 13, CDDestinoId = 14, tamaño = "XL", estadoGuia = "RENDIDA",  tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 8,  clienteID = 2, numeroGuia = 008, fechaImposicion = new DateTime(2026, 04, 12), CDOrigenId = 15, CDDestinoId = 16, tamaño = "L",  estadoGuia = "RENDIDA",  tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 9,  clienteID = 3, numeroGuia = 009, fechaImposicion = new DateTime(2026, 04, 13), CDOrigenId = 17, CDDestinoId = 18, tamaño = "M",  estadoGuia = "RENDIDA",  tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 10, clienteID = 4, numeroGuia = 010, fechaImposicion = new DateTime(2026, 04, 14), CDOrigenId = 17, CDDestinoId = 1,  tamaño = "S",  estadoGuia = "ADMITIDA", tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 11, clienteID = 1, numeroGuia = 011, fechaImposicion = new DateTime(2026, 04, 15), CDOrigenId = 1,  CDDestinoId = 2,  tamaño = "XL", estadoGuia = "RENDIDA",  tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 12, clienteID = 2, numeroGuia = 012, fechaImposicion = new DateTime(2026, 04, 16), CDOrigenId = 3,  CDDestinoId = 4,  tamaño = "L",  estadoGuia = "RENDIDA",  tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 13, clienteID = 3, numeroGuia = 013, fechaImposicion = new DateTime(2026, 04, 17), CDOrigenId = 5,  CDDestinoId = 6,  tamaño = "M",  estadoGuia = "RENDIDA",  tipoImposicion = "C", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 14, clienteID = 4, numeroGuia = 014, fechaImposicion = new DateTime(2026, 04, 18), CDOrigenId = 7,  CDDestinoId = 8,  tamaño = "S",  estadoGuia = "RENDIDA",  tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 15, clienteID = 1, numeroGuia = 015, fechaImposicion = new DateTime(2026, 04, 19), CDOrigenId = 9,  CDDestinoId = 10, tamaño = "XL", estadoGuia = "ADMITIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 16, clienteID = 2, numeroGuia = 016, fechaImposicion = new DateTime(2026, 04, 20), CDOrigenId = 11, CDDestinoId = 12, tamaño = "L",  estadoGuia = "RENDIDA",  tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 17, clienteID = 3, numeroGuia = 017, fechaImposicion = new DateTime(2026, 04, 21), CDOrigenId = 13, CDDestinoId = 14, tamaño = "M",  estadoGuia = "RENDIDA",  tipoImposicion = "C", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 18, clienteID = 4, numeroGuia = 018, fechaImposicion = new DateTime(2026, 04, 22), CDOrigenId = 15, CDDestinoId = 16, tamaño = "S",  estadoGuia = "RENDIDA",  tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 19, clienteID = 5, numeroGuia = 019, fechaImposicion = new DateTime(2026, 04, 23), CDOrigenId = 17, CDDestinoId = 18, tamaño = "XL", estadoGuia = "RENDIDA",  tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 20, clienteID = 1, numeroGuia = 020, fechaImposicion = new DateTime(2026, 04, 24), CDOrigenId = 1,  CDDestinoId = 16, tamaño = "L",  estadoGuia = "ADMITIDA", tipoImposicion = "C", tipoEntrega = "D", tarifarioId = 1 },
        };

        public List<Cajas> LCajas => new List<Cajas>
        {
            new Cajas { ID = 1, nombre = "S" },
            new Cajas { ID = 2, nombre = "M" },
            new Cajas { ID = 3, nombre = "L" },
            new Cajas { ID = 4, nombre = "XL" }
        };

        public decimal ObtenerCoeficiente(int origenId, int destinoId, string tipoCaja)
        {
            if (origenId == destinoId)
                return 0;

            var tarifa = TarifaTransporteAlmacen.tarifaTransportes
                .FirstOrDefault(t =>
                    (t.CDOrigenId == origenId && t.CDDestinoId == destinoId) ||
                    (t.CDOrigenId == destinoId && t.CDDestinoId == origenId));

            if (tarifa == null)
                throw new Exception($"No se encontró tarifa de transporte para CD origen {origenId} y CD destino {destinoId}.");

            return tipoCaja switch
            {
                "S"  => tarifa.CoeficienteS,
                "M"  => tarifa.CoeficienteM,
                "L"  => tarifa.CoeficienteL,
                "XL" => tarifa.CoeficienteXL,
                _    => throw new Exception($"Tipo de caja '{tipoCaja}' no válido.")
            };
        }

        public decimal ObtenerTarifaRetiroDomicilio(int tarifarioId)
        {
            var tarifa = TarifarioAlmacen.tarifarios
                .FirstOrDefault(t => t.TarifarioId == tarifarioId);
            return tarifa?.TarifaRetiroDomicilio ?? 0;
        }

        public decimal ObtenerTarifaEntregaAgencia(int tarifarioId)
        {
            var tarifa = TarifarioAlmacen.tarifarios
                .FirstOrDefault(t => t.TarifarioId == tarifarioId);
            return tarifa?.TarifaEntregaAgencia ?? 0;
        }

        public decimal ObtenerTarifaDistribucionDomicilio(int tarifarioId)
        {
            var tarifa = TarifarioAlmacen.tarifarios
                .FirstOrDefault(t => t.TarifarioId == tarifarioId);
            return tarifa?.TarifaDistribucionDomicilio ?? 0;
        }
    }
}
