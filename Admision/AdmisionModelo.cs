using GrupoE_Tutasa.EmitirFactura;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Admision
{
    internal class AdmisionModelo
    {
        public List<GuiasAAdmitir> LGuiasAAdmitir => new List<GuiasAAdmitir>
        {
            new GuiasAAdmitir { Id = 1,  clienteID = 1, numeroGuia = 001, fechaImposicion = new DateTime(2026, 04, 05), CDOrigenId = 1,  CDDestinoId = 2,  tamaño = "L",  estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 2,  clienteID = 2, numeroGuia = 002, fechaImposicion = new DateTime(2026, 04, 06), CDOrigenId = 3,  CDDestinoId = 4,  tamaño = "M",  estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 3,  clienteID = 3, numeroGuia = 003, fechaImposicion = new DateTime(2026, 04, 07), CDOrigenId = 5,  CDDestinoId = 6,  tamaño = "S",  estadoGuia = "RENDIDA", tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 4,  clienteID = 4, numeroGuia = 004, fechaImposicion = new DateTime(2026, 04, 08), CDOrigenId = 7,  CDDestinoId = 8,  tamaño = "XL", estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 5,  clienteID = 5, numeroGuia = 005, fechaImposicion = new DateTime(2026, 04, 09), CDOrigenId = 9,  CDDestinoId = 10, tamaño = "M",  estadoGuia = "ADMITIDA", tipoImposicion = "C", tipoEntrega = "A" ,tarifarioId = 1 },
            new GuiasAAdmitir { Id = 6,  clienteID = 6, numeroGuia = 006, fechaImposicion = new DateTime(2026, 04, 10), CDOrigenId = 11, CDDestinoId = 12, tamaño = "S",  estadoGuia = "RENDIDA", tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 7,  clienteID = 1, numeroGuia = 007, fechaImposicion = new DateTime(2026, 04, 11), CDOrigenId = 13, CDDestinoId = 14, tamaño = "XL", estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 8,  clienteID = 2, numeroGuia = 008, fechaImposicion = new DateTime(2026, 04, 12), CDOrigenId = 15, CDDestinoId = 16, tamaño = "L",  estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 9,  clienteID = 3, numeroGuia = 009, fechaImposicion = new DateTime(2026, 04, 13), CDOrigenId = 17, CDDestinoId = 18, tamaño = "M",  estadoGuia = "RENDIDA", tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 10, clienteID = 4, numeroGuia = 010, fechaImposicion = new DateTime(2026, 04, 14), CDOrigenId = 17, CDDestinoId = 1,  tamaño = "S",  estadoGuia = "ADMITIDA", tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 11, clienteID = 1, numeroGuia = 011, fechaImposicion = new DateTime(2026, 04, 15), CDOrigenId = 1,  CDDestinoId = 2,  tamaño = "XL", estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 12, clienteID = 2, numeroGuia = 012, fechaImposicion = new DateTime(2026, 04, 16), CDOrigenId = 3,  CDDestinoId = 4,  tamaño = "L",  estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 13, clienteID = 3, numeroGuia = 013, fechaImposicion = new DateTime(2026, 04, 17), CDOrigenId = 5,  CDDestinoId = 6,  tamaño = "M",  estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 14, clienteID = 4, numeroGuia = 014, fechaImposicion = new DateTime(2026, 04, 18), CDOrigenId = 7,  CDDestinoId = 8,  tamaño = "S",  estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 15, clienteID = 1, numeroGuia = 015, fechaImposicion = new DateTime(2026, 04, 19), CDOrigenId = 9,  CDDestinoId = 10, tamaño = "XL", estadoGuia = "ADMITIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 16, clienteID = 2, numeroGuia = 016, fechaImposicion = new DateTime(2026, 04, 20), CDOrigenId = 11, CDDestinoId = 12, tamaño = "L",  estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 17, clienteID = 3, numeroGuia = 017, fechaImposicion = new DateTime(2026, 04, 21), CDOrigenId = 13, CDDestinoId = 14, tamaño = "M",  estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 18, clienteID = 4, numeroGuia = 018, fechaImposicion = new DateTime(2026, 04, 22), CDOrigenId = 15, CDDestinoId = 16, tamaño = "S",  estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 19, clienteID = 5, numeroGuia = 019, fechaImposicion = new DateTime(2026, 04, 23), CDOrigenId = 17, CDDestinoId = 18, tamaño = "XL", estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 20, clienteID = 1, numeroGuia = 020, fechaImposicion = new DateTime(2026, 04, 24), CDOrigenId = 1,  CDDestinoId = 16, tamaño = "L",  estadoGuia = "ADMITIDA", tipoImposicion = "C", tipoEntrega = "D", tarifarioId = 1 },
        };

        public List<Cajas> LCajas => new List<Cajas>
        {
            new Cajas { ID = 1, nombre = "S" },
            new Cajas { ID = 2, nombre = "M" },
            new Cajas { ID = 3, nombre = "L" },
            new Cajas { ID = 4, nombre = "XL" }
        };
        public List<Tarifario> LTarifarios => new List<Tarifario>
        {
            new Tarifario { TarifarioId = 1, TarifaRetiroDomicilio = 10000, TarifaEntregaAgencia = 5000, TarifaDistribucionDomicilio = 10000, TarifaUnitarioTransporte = 1 }
        };
        public List<TarifaTransporte> LTarifasTransporte => new List<TarifaTransporte>
        {
            // Buenos Aires (1)
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 2,  CoeficienteS = 3000,  CoeficienteM = 6000,  CoeficienteL = 12000, CoeficienteXL = 24000  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 3,  CoeficienteS = 7000,  CoeficienteM = 14000, CoeficienteL = 28000, CoeficienteXL = 56000  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 4,  CoeficienteS = 10500, CoeficienteM = 21000, CoeficienteL = 42000, CoeficienteXL = 84000  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 5,  CoeficienteS = 600,   CoeficienteM = 1200,  CoeficienteL = 2400,  CoeficienteXL = 4800   },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 6,  CoeficienteS = 4150,  CoeficienteM = 8300,  CoeficienteL = 16600, CoeficienteXL = 33200  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 7,  CoeficienteS = 11000, CoeficienteM = 22000, CoeficienteL = 44000, CoeficienteXL = 88000  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 8,  CoeficienteS = 14900, CoeficienteM = 29800, CoeficienteL = 59600, CoeficienteXL = 119200 },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 9,  CoeficienteS = 11500, CoeficienteM = 23000, CoeficienteL = 46000, CoeficienteXL = 92000  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 10, CoeficienteS = 6400,  CoeficienteM = 12800, CoeficienteL = 25600, CoeficienteXL = 51200  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 11, CoeficienteS = 12500, CoeficienteM = 25000, CoeficienteL = 50000, CoeficienteXL = 100000 },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 12, CoeficienteS = 4700,  CoeficienteM = 9400,  CoeficienteL = 18800, CoeficienteXL = 37600  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 13, CoeficienteS = 9200,  CoeficienteM = 18400, CoeficienteL = 36800, CoeficienteXL = 73600  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 14, CoeficienteS = 10000, CoeficienteM = 20000, CoeficienteL = 40000, CoeficienteXL = 80000  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 15, CoeficienteS = 9300,  CoeficienteM = 18600, CoeficienteL = 37200, CoeficienteXL = 74400  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 16, CoeficienteS = 7900,  CoeficienteM = 15800, CoeficienteL = 31600, CoeficienteXL = 63200  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 17, CoeficienteS = 11300, CoeficienteM = 22600, CoeficienteL = 45200, CoeficienteXL = 90400  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 18, CoeficienteS = 15000, CoeficienteM = 30000, CoeficienteL = 60000, CoeficienteXL = 120000 },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 19, CoeficienteS = 11500, CoeficienteM = 23000, CoeficienteL = 46000, CoeficienteXL = 92000  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 20, CoeficienteS = 11800, CoeficienteM = 23600, CoeficienteL = 47200, CoeficienteXL = 94400  },
            // Rosario (2)
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 3,  CoeficienteS = 4000,  CoeficienteM = 8000,  CoeficienteL = 16000, CoeficienteXL = 32000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 4,  CoeficienteS = 8500,  CoeficienteM = 17000, CoeficienteL = 34000, CoeficienteXL = 68000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 5,  CoeficienteS = 3500,  CoeficienteM = 7000,  CoeficienteL = 14000, CoeficienteXL = 28000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 6,  CoeficienteS = 7100,  CoeficienteM = 14200, CoeficienteL = 28400, CoeficienteXL = 56800  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 7,  CoeficienteS = 9000,  CoeficienteM = 18000, CoeficienteL = 36000, CoeficienteXL = 72000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 8,  CoeficienteS = 12000, CoeficienteM = 24000, CoeficienteL = 48000, CoeficienteXL = 96000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 9,  CoeficienteS = 11000, CoeficienteM = 22000, CoeficienteL = 44000, CoeficienteXL = 88000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 10, CoeficienteS = 7600,  CoeficienteM = 15200, CoeficienteL = 30400, CoeficienteXL = 60800  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 11, CoeficienteS = 9500,  CoeficienteM = 19000, CoeficienteL = 38000, CoeficienteXL = 76000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 12, CoeficienteS = 1700,  CoeficienteM = 3400,  CoeficienteL = 6800,  CoeficienteXL = 13600  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 13, CoeficienteS = 6300,  CoeficienteM = 12600, CoeficienteL = 25200, CoeficienteXL = 50400  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 14, CoeficienteS = 8000,  CoeficienteM = 16000, CoeficienteL = 32000, CoeficienteXL = 64000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 15, CoeficienteS = 6400,  CoeficienteM = 12800, CoeficienteL = 25600, CoeficienteXL = 51200  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 16, CoeficienteS = 6100,  CoeficienteM = 12200, CoeficienteL = 24400, CoeficienteXL = 48800  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 17, CoeficienteS = 8300,  CoeficienteM = 16600, CoeficienteL = 33200, CoeficienteXL = 66400  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 18, CoeficienteS = 12100, CoeficienteM = 24200, CoeficienteL = 48400, CoeficienteXL = 96800  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 19, CoeficienteS = 8500,  CoeficienteM = 17000, CoeficienteL = 34000, CoeficienteXL = 68000  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 20, CoeficienteS = 8900,  CoeficienteM = 17800, CoeficienteL = 35600, CoeficienteXL = 71200  },
            // Córdoba (3)
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 4,  CoeficienteS = 6100,  CoeficienteM = 12200, CoeficienteL = 24400, CoeficienteXL = 48800  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 5,  CoeficienteS = 7600,  CoeficienteM = 15200, CoeficienteL = 30400, CoeficienteXL = 60800  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 6,  CoeficienteS = 11000, CoeficienteM = 22000, CoeficienteL = 44000, CoeficienteXL = 88000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 7,  CoeficienteS = 5800,  CoeficienteM = 11600, CoeficienteL = 23200, CoeficienteXL = 46400  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 8,  CoeficienteS = 8900,  CoeficienteM = 17800, CoeficienteL = 35600, CoeficienteXL = 71200  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 9,  CoeficienteS = 11000, CoeficienteM = 22000, CoeficienteL = 44000, CoeficienteXL = 88000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 10, CoeficienteS = 10500, CoeficienteM = 21000, CoeficienteL = 42000, CoeficienteXL = 84000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 11, CoeficienteS = 5500,  CoeficienteM = 11000, CoeficienteL = 22000, CoeficienteXL = 44000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 12, CoeficienteS = 3500,  CoeficienteM = 7000,  CoeficienteL = 14000, CoeficienteXL = 28000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 13, CoeficienteS = 9000,  CoeficienteM = 18000, CoeficienteL = 36000, CoeficienteXL = 72000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 14, CoeficienteS = 11000, CoeficienteM = 22000, CoeficienteL = 44000, CoeficienteXL = 88000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 15, CoeficienteS = 8500,  CoeficienteM = 17000, CoeficienteL = 34000, CoeficienteXL = 68000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 16, CoeficienteS = 4300,  CoeficienteM = 8600,  CoeficienteL = 17200, CoeficienteXL = 34400  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 17, CoeficienteS = 4400,  CoeficienteM = 8800,  CoeficienteL = 17600, CoeficienteXL = 35200  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 18, CoeficienteS = 9100,  CoeficienteM = 18200, CoeficienteL = 36400, CoeficienteXL = 72800  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 19, CoeficienteS = 4500,  CoeficienteM = 9000,  CoeficienteL = 18000, CoeficienteXL = 36000  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 20, CoeficienteS = 11000, CoeficienteM = 22000, CoeficienteL = 44000, CoeficienteXL = 88000  },
            // Mendoza (4)
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 5,  CoeficienteS = 11000, CoeficienteM = 22000, CoeficienteL = 44000, CoeficienteXL = 88000  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 6,  CoeficienteS = 13500, CoeficienteM = 27000, CoeficienteL = 54000, CoeficienteXL = 108000 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 7,  CoeficienteS = 1700,  CoeficienteM = 3400,  CoeficienteL = 6800,  CoeficienteXL = 13600  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 8,  CoeficienteS = 12400, CoeficienteM = 24800, CoeficienteL = 49600, CoeficienteXL = 99200  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 9,  CoeficienteS = 8000,  CoeficienteM = 16000, CoeficienteL = 32000, CoeficienteXL = 64000  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 10, CoeficienteS = 12000, CoeficienteM = 24000, CoeficienteL = 48000, CoeficienteXL = 96000  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 11, CoeficienteS = 9500,  CoeficienteM = 19000, CoeficienteL = 38000, CoeficienteXL = 76000  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 12, CoeficienteS = 9000,  CoeficienteM = 18000, CoeficienteL = 36000, CoeficienteXL = 72000  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 13, CoeficienteS = 14000, CoeficienteM = 28000, CoeficienteL = 56000, CoeficienteXL = 112000 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 14, CoeficienteS = 16000, CoeficienteM = 32000, CoeficienteL = 64000, CoeficienteXL = 128000 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 15, CoeficienteS = 13500, CoeficienteM = 27000, CoeficienteL = 54000, CoeficienteXL = 108000 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 16, CoeficienteS = 2600,  CoeficienteM = 5200,  CoeficienteL = 10400, CoeficienteXL = 20800  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 17, CoeficienteS = 7500,  CoeficienteM = 15000, CoeficienteL = 30000, CoeficienteXL = 60000  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 18, CoeficienteS = 13000, CoeficienteM = 26000, CoeficienteL = 52000, CoeficienteXL = 104000 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 19, CoeficienteS = 4500,  CoeficienteM = 9000,  CoeficienteL = 18000, CoeficienteXL = 36000  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 20, CoeficienteS = 16000, CoeficienteM = 32000, CoeficienteL = 64000, CoeficienteXL = 128000 },
            // La Plata (5)
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 6,  CoeficienteS = 3650,  CoeficienteM = 7300,  CoeficienteL = 14600, CoeficienteXL = 29200  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 7,  CoeficienteS = 11500, CoeficienteM = 23000, CoeficienteL = 46000, CoeficienteXL = 92000  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 8,  CoeficienteS = 15500, CoeficienteM = 31000, CoeficienteL = 62000, CoeficienteXL = 124000 },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 9,  CoeficienteS = 11400, CoeficienteM = 22800, CoeficienteL = 45600, CoeficienteXL = 91200  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 10, CoeficienteS = 6300,  CoeficienteM = 12600, CoeficienteL = 25200, CoeficienteXL = 50400  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 11, CoeficienteS = 13000, CoeficienteM = 26000, CoeficienteL = 52000, CoeficienteXL = 104000 },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 12, CoeficienteS = 5200,  CoeficienteM = 10400, CoeficienteL = 20800, CoeficienteXL = 41600  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 13, CoeficienteS = 9700,  CoeficienteM = 19400, CoeficienteL = 38800, CoeficienteXL = 77600  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 14, CoeficienteS = 10500, CoeficienteM = 21000, CoeficienteL = 42000, CoeficienteXL = 84000  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 15, CoeficienteS = 9800,  CoeficienteM = 19600, CoeficienteL = 39200, CoeficienteXL = 78400  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 16, CoeficienteS = 8400,  CoeficienteM = 16800, CoeficienteL = 33600, CoeficienteXL = 67200  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 17, CoeficienteS = 11800, CoeficienteM = 23600, CoeficienteL = 47200, CoeficienteXL = 94400  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 18, CoeficienteS = 15600, CoeficienteM = 31200, CoeficienteL = 62400, CoeficienteXL = 124800 },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 19, CoeficienteS = 12000, CoeficienteM = 24000, CoeficienteL = 48000, CoeficienteXL = 96000  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 20, CoeficienteS = 12300, CoeficienteM = 24600, CoeficienteL = 49200, CoeficienteXL = 98400  },
            // Mar del Plata (6)
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 7,  CoeficienteS = 14000, CoeficienteM = 28000, CoeficienteL = 56000, CoeficienteXL = 112000 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 8,  CoeficienteS = 19000, CoeficienteM = 38000, CoeficienteL = 76000, CoeficienteXL = 152000 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 9,  CoeficienteS = 10500, CoeficienteM = 21000, CoeficienteL = 42000, CoeficienteXL = 84000  },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 10, CoeficienteS = 4500,  CoeficienteM = 9000,  CoeficienteL = 18000, CoeficienteXL = 36000  },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 11, CoeficienteS = 16500, CoeficienteM = 33000, CoeficienteL = 66000, CoeficienteXL = 132000 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 12, CoeficienteS = 8800,  CoeficienteM = 17600, CoeficienteL = 35200, CoeficienteXL = 70400  },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 13, CoeficienteS = 13300, CoeficienteM = 26600, CoeficienteL = 53200, CoeficienteXL = 106400 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 14, CoeficienteS = 14100, CoeficienteM = 28200, CoeficienteL = 56400, CoeficienteXL = 112800 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 15, CoeficienteS = 13400, CoeficienteM = 26800, CoeficienteL = 53600, CoeficienteXL = 107200 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 16, CoeficienteS = 11000, CoeficienteM = 22000, CoeficienteL = 44000, CoeficienteXL = 88000  },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 17, CoeficienteS = 15400, CoeficienteM = 30800, CoeficienteL = 61600, CoeficienteXL = 123200 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 18, CoeficienteS = 19100, CoeficienteM = 38200, CoeficienteL = 76400, CoeficienteXL = 152800 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 19, CoeficienteS = 14500, CoeficienteM = 29000, CoeficienteL = 58000, CoeficienteXL = 116000 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 20, CoeficienteS = 15900, CoeficienteM = 31800, CoeficienteL = 63600, CoeficienteXL = 127200 },
            // San Juan (7)
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 8,  CoeficienteS = 10800, CoeficienteM = 21600, CoeficienteL = 43200, CoeficienteXL = 86400  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 9,  CoeficienteS = 9500,  CoeficienteM = 19000, CoeficienteL = 38000, CoeficienteXL = 76000  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 10, CoeficienteS = 13500, CoeficienteM = 27000, CoeficienteL = 54000, CoeficienteXL = 108000 },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 11, CoeficienteS = 8000,  CoeficienteM = 16000, CoeficienteL = 32000, CoeficienteXL = 64000  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 12, CoeficienteS = 9500,  CoeficienteM = 19000, CoeficienteL = 38000, CoeficienteXL = 76000  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 13, CoeficienteS = 13500, CoeficienteM = 27000, CoeficienteL = 54000, CoeficienteXL = 108000 },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 14, CoeficienteS = 15500, CoeficienteM = 31000, CoeficienteL = 62000, CoeficienteXL = 124000 },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 15, CoeficienteS = 13000, CoeficienteM = 26000, CoeficienteL = 52000, CoeficienteXL = 104000 },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 16, CoeficienteS = 3200,  CoeficienteM = 6400,  CoeficienteL = 12800, CoeficienteXL = 25600  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 17, CoeficienteS = 6000,  CoeficienteM = 12000, CoeficienteL = 24000, CoeficienteXL = 48000  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 18, CoeficienteS = 11500, CoeficienteM = 23000, CoeficienteL = 46000, CoeficienteXL = 92000  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 19, CoeficienteS = 4400,  CoeficienteM = 8800,  CoeficienteL = 17600, CoeficienteXL = 35200  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 20, CoeficienteS = 15500, CoeficienteM = 31000, CoeficienteL = 62000, CoeficienteXL = 124000 },
            // Salta (8)
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 9,  CoeficienteS = 20500, CoeficienteM = 41000, CoeficienteL = 82000, CoeficienteXL = 164000 },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 10, CoeficienteS = 19000, CoeficienteM = 38000, CoeficienteL = 76000, CoeficienteXL = 152000 },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 11, CoeficienteS = 3100,  CoeficienteM = 6200,  CoeficienteL = 12400, CoeficienteXL = 24800  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 12, CoeficienteS = 10300, CoeficienteM = 20600, CoeficienteL = 41200, CoeficienteXL = 82400  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 13, CoeficienteS = 8300,  CoeficienteM = 16600, CoeficienteL = 33200, CoeficienteXL = 66400  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 14, CoeficienteS = 10300, CoeficienteM = 20600, CoeficienteL = 41200, CoeficienteXL = 82400  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 15, CoeficienteS = 8200,  CoeficienteM = 16400, CoeficienteL = 32800, CoeficienteXL = 65600  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 16, CoeficienteS = 11500, CoeficienteM = 23000, CoeficienteL = 46000, CoeficienteXL = 92000  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 17, CoeficienteS = 5200,  CoeficienteM = 10400, CoeficienteL = 20800, CoeficienteXL = 41600  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 18, CoeficienteS = 900,   CoeficienteM = 1800,  CoeficienteL = 3600,  CoeficienteXL = 7200   },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 19, CoeficienteS = 6700,  CoeficienteM = 13400, CoeficienteL = 26800, CoeficienteXL = 53600  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 20, CoeficienteS = 10000, CoeficienteM = 20000, CoeficienteL = 40000, CoeficienteXL = 80000  },
            // Neuquén (9)
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 10, CoeficienteS = 5400,  CoeficienteM = 10800, CoeficienteL = 21600, CoeficienteXL = 43200  },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 11, CoeficienteS = 17500, CoeficienteM = 35000, CoeficienteL = 70000, CoeficienteXL = 140000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 12, CoeficienteS = 12500, CoeficienteM = 25000, CoeficienteL = 50000, CoeficienteXL = 100000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 13, CoeficienteS = 19500, CoeficienteM = 39000, CoeficienteL = 78000, CoeficienteXL = 156000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 14, CoeficienteS = 21000, CoeficienteM = 42000, CoeficienteL = 84000, CoeficienteXL = 168000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 15, CoeficienteS = 19000, CoeficienteM = 38000, CoeficienteL = 76000, CoeficienteXL = 152000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 16, CoeficienteS = 8500,  CoeficienteM = 17000, CoeficienteL = 34000, CoeficienteXL = 68000  },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 17, CoeficienteS = 15500, CoeficienteM = 31000, CoeficienteL = 62000, CoeficienteXL = 124000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 18, CoeficienteS = 21000, CoeficienteM = 42000, CoeficienteL = 84000, CoeficienteXL = 168000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 19, CoeficienteS = 12500, CoeficienteM = 25000, CoeficienteL = 50000, CoeficienteXL = 100000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 20, CoeficienteS = 21500, CoeficienteM = 43000, CoeficienteL = 86000, CoeficienteXL = 172000 },
            // Bahía Blanca (10)
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 11, CoeficienteS = 16000, CoeficienteM = 32000, CoeficienteL = 64000, CoeficienteXL = 128000 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 12, CoeficienteS = 9300,  CoeficienteM = 18600, CoeficienteL = 37200, CoeficienteXL = 74400  },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 13, CoeficienteS = 14500, CoeficienteM = 29000, CoeficienteL = 58000, CoeficienteXL = 116000 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 14, CoeficienteS = 15500, CoeficienteM = 31000, CoeficienteL = 62000, CoeficienteXL = 124000 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 15, CoeficienteS = 14000, CoeficienteM = 28000, CoeficienteL = 56000, CoeficienteXL = 112000 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 16, CoeficienteS = 9000,  CoeficienteM = 18000, CoeficienteL = 36000, CoeficienteXL = 72000  },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 17, CoeficienteS = 14500, CoeficienteM = 29000, CoeficienteL = 58000, CoeficienteXL = 116000 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 18, CoeficienteS = 19500, CoeficienteM = 39000, CoeficienteL = 78000, CoeficienteXL = 156000 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 19, CoeficienteS = 13500, CoeficienteM = 27000, CoeficienteL = 54000, CoeficienteXL = 108000 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 20, CoeficienteS = 16500, CoeficienteM = 33000, CoeficienteL = 66000, CoeficienteXL = 132000 },
            // Tucumán (11)
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 12, CoeficienteS = 7800,  CoeficienteM = 15600, CoeficienteL = 31200, CoeficienteXL = 62400  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 13, CoeficienteS = 7500,  CoeficienteM = 15000, CoeficienteL = 30000, CoeficienteXL = 60000  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 14, CoeficienteS = 9500,  CoeficienteM = 19000, CoeficienteL = 38000, CoeficienteXL = 76000  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 15, CoeficienteS = 7400,  CoeficienteM = 14800, CoeficienteL = 29600, CoeficienteXL = 59200  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 16, CoeficienteS = 8500,  CoeficienteM = 17000, CoeficienteL = 34000, CoeficienteXL = 68000  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 17, CoeficienteS = 2300,  CoeficienteM = 4600,  CoeficienteL = 9200,  CoeficienteXL = 18400  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 18, CoeficienteS = 3400,  CoeficienteM = 6800,  CoeficienteL = 13600, CoeficienteXL = 27200  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 19, CoeficienteS = 4400,  CoeficienteM = 8800,  CoeficienteL = 17600, CoeficienteXL = 35200  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 20, CoeficienteS = 9200,  CoeficienteM = 18400, CoeficienteL = 36800, CoeficienteXL = 73600  },
            // Santa Fe (12)
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 13, CoeficienteS = 5600,  CoeficienteM = 11200, CoeficienteL = 22400, CoeficienteXL = 44800  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 14, CoeficienteS = 7400,  CoeficienteM = 14800, CoeficienteL = 29600, CoeficienteXL = 59200  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 15, CoeficienteS = 5400,  CoeficienteM = 10800, CoeficienteL = 21600, CoeficienteXL = 43200  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 16, CoeficienteS = 6500,  CoeficienteM = 13000, CoeficienteL = 26000, CoeficienteXL = 52000  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 17, CoeficienteS = 6600,  CoeficienteM = 13200, CoeficienteL = 26400, CoeficienteXL = 52800  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 18, CoeficienteS = 10400, CoeficienteM = 20800, CoeficienteL = 41600, CoeficienteXL = 83200  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 19, CoeficienteS = 7000,  CoeficienteM = 14000, CoeficienteL = 28000, CoeficienteXL = 56000  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 20, CoeficienteS = 8000,  CoeficienteM = 16000, CoeficienteL = 32000, CoeficienteXL = 64000  },
            // Corrientes (13)
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 14, CoeficienteS = 3200,  CoeficienteM = 6400,  CoeficienteL = 12800, CoeficienteXL = 25600  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 15, CoeficienteS = 200,   CoeficienteM = 400,   CoeficienteL = 800,   CoeficienteXL = 1600   },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 16, CoeficienteS = 11500, CoeficienteM = 23000, CoeficienteL = 46000, CoeficienteXL = 92000  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 17, CoeficienteS = 8500,  CoeficienteM = 17000, CoeficienteL = 34000, CoeficienteXL = 68000  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 18, CoeficienteS = 8600,  CoeficienteM = 17200, CoeficienteL = 34400, CoeficienteXL = 68800  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 19, CoeficienteS = 10000, CoeficienteM = 20000, CoeficienteL = 40000, CoeficienteXL = 80000  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 20, CoeficienteS = 1900,  CoeficienteM = 3800,  CoeficienteL = 7600,  CoeficienteXL = 15200  },
            // Posadas (14)
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 15, CoeficienteS = 3400,  CoeficienteM = 6800,  CoeficienteL = 13600, CoeficienteXL = 27200  },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 16, CoeficienteS = 13500, CoeficienteM = 27000, CoeficienteL = 54000, CoeficienteXL = 108000 },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 17, CoeficienteS = 10500, CoeficienteM = 21000, CoeficienteL = 42000, CoeficienteXL = 84000  },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 18, CoeficienteS = 10600, CoeficienteM = 21200, CoeficienteL = 42400, CoeficienteXL = 84800  },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 19, CoeficienteS = 12000, CoeficienteM = 24000, CoeficienteL = 48000, CoeficienteXL = 96000  },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 20, CoeficienteS = 3100,  CoeficienteM = 6200,  CoeficienteL = 12400, CoeficienteXL = 24800  },
            // Resistencia (15)
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 16, CoeficienteS = 11500, CoeficienteM = 23000, CoeficienteL = 46000, CoeficienteXL = 92000  },
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 17, CoeficienteS = 8400,  CoeficienteM = 16800, CoeficienteL = 33600, CoeficienteXL = 67200  },
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 18, CoeficienteS = 8500,  CoeficienteM = 17000, CoeficienteL = 34000, CoeficienteXL = 68000  },
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 19, CoeficienteS = 9900,  CoeficienteM = 19800, CoeficienteL = 39600, CoeficienteXL = 79200  },
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 20, CoeficienteS = 1700,  CoeficienteM = 3400,  CoeficienteL = 6800,  CoeficienteXL = 13600  },
            // San Luis (16)
            new TarifaTransporte { CDOrigenId = 16, CDDestinoId = 17, CoeficienteS = 6500,  CoeficienteM = 13000, CoeficienteL = 26000, CoeficienteXL = 52000  },
            new TarifaTransporte { CDOrigenId = 16, CDDestinoId = 18, CoeficienteS = 12000, CoeficienteM = 24000, CoeficienteL = 48000, CoeficienteXL = 96000  },
            new TarifaTransporte { CDOrigenId = 16, CDDestinoId = 19, CoeficienteS = 4500,  CoeficienteM = 9000,  CoeficienteL = 18000, CoeficienteXL = 36000  },
            new TarifaTransporte { CDOrigenId = 16, CDDestinoId = 20, CoeficienteS = 13200, CoeficienteM = 26400, CoeficienteL = 52800, CoeficienteXL = 105600 },
            // Catamarca (17)
            new TarifaTransporte { CDOrigenId = 17, CDDestinoId = 18, CoeficienteS = 4400,  CoeficienteM = 8800,  CoeficienteL = 17600, CoeficienteXL = 35200  },
            new TarifaTransporte { CDOrigenId = 17, CDDestinoId = 19, CoeficienteS = 1500,  CoeficienteM = 3000,  CoeficienteL = 6000,  CoeficienteXL = 12000  },
            new TarifaTransporte { CDOrigenId = 17, CDDestinoId = 20, CoeficienteS = 10100, CoeficienteM = 20200, CoeficienteL = 40400, CoeficienteXL = 80800  },
            // Jujuy (18)
            new TarifaTransporte { CDOrigenId = 18, CDDestinoId = 19, CoeficienteS = 6000,  CoeficienteM = 12000, CoeficienteL = 24000, CoeficienteXL = 48000  },
            new TarifaTransporte { CDOrigenId = 18, CDDestinoId = 20, CoeficienteS = 10300, CoeficienteM = 20600, CoeficienteL = 41200, CoeficienteXL = 82400  },
            // La Rioja (19)
            new TarifaTransporte { CDOrigenId = 19, CDDestinoId = 20, CoeficienteS = 11600, CoeficienteM = 23200, CoeficienteL = 46400, CoeficienteXL = 92800  },
        };
        public decimal ObtenerCoeficiente(int origenId, int destinoId, string tipoCaja)
        {
            var tarifa = LTarifasTransporte.FirstOrDefault(t =>
                t.CDOrigenId == origenId &&
                t.CDDestinoId == destinoId);

            if (tarifa == null)
                return 0;

            return tipoCaja switch
            {
                "S" => tarifa.CoeficienteS,
                "M" => tarifa.CoeficienteM,
                "L" => tarifa.CoeficienteL,
                "XL" => tarifa.CoeficienteXL,
            };
        }
        public decimal ObtenerPrecioUnitarioTransporte(int tarifarioId)
        {
            foreach (var tarifaUnitaria in LTarifarios)
            {
                if (tarifarioId == tarifaUnitaria.TarifarioId)
                { return tarifaUnitaria.TarifaUnitarioTransporte; }
            }
            return 0;
        }
        public decimal ObtenerTarifaRetiroDomicilio(int tarifarioId)
        {
            foreach (var tarifa in LTarifarios)
            {
                if (tarifarioId == tarifa.TarifarioId)
                { return tarifa.TarifaRetiroDomicilio; }
            }
            return 0;
        }
        public decimal ObtenerTarifaEntregaAgencia(int tarifarioId)
        {
            foreach (var tarifa in LTarifarios)
            {
                if (tarifarioId == tarifa.TarifarioId)
                { return tarifa.TarifaEntregaAgencia; }
            }
            return 0;
        }
        public decimal ObtenerTarifaDistribucionDomicilio(int tarifarioId)
        {
            foreach (var tarifa in LTarifarios)
            {
                if (tarifarioId == tarifa.TarifarioId)
                { return tarifa.TarifaDistribucionDomicilio; }
            }
            return 0;
        }
    }
}
