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
            new GuiasAAdmitir { Id = 1,  clienteID = 1, numeroGuia = 001, fechaImposicion = new DateTime(2026, 04, 05), CDOrigenId = 1,  CDDestinoId = 2,  tamaño = "L",  estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 2,  clienteID = 2, numeroGuia = 002, fechaImposicion = new DateTime(2026, 04, 06), CDOrigenId = 3,  CDDestinoId = 4,  tamaño = "M",  estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 3,  clienteID = 3, numeroGuia = 003, fechaImposicion = new DateTime(2026, 04, 07), CDOrigenId = 5,  CDDestinoId = 6,  tamaño = "S",  estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 4,  clienteID = 4, numeroGuia = 004, fechaImposicion = new DateTime(2026, 04, 08), CDOrigenId = 7,  CDDestinoId = 8,  tamaño = "XL", estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 5,  clienteID = 5, numeroGuia = 005, fechaImposicion = new DateTime(2026, 04, 09), CDOrigenId = 9,  CDDestinoId = 10, tamaño = "M",  estadoGuia = "ADMITIDA", tipoImposicion = "C", tipoEntrega = "A" ,tarifarioId = 1 },
            new GuiasAAdmitir { Id = 6,  clienteID = 6, numeroGuia = 006, fechaImposicion = new DateTime(2026, 04, 10), CDOrigenId = 11, CDDestinoId = 12, tamaño = "S",  estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 7,  clienteID = 1, numeroGuia = 007, fechaImposicion = new DateTime(2026, 04, 11), CDOrigenId = 13, CDDestinoId = 14, tamaño = "XL", estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 8,  clienteID = 2, numeroGuia = 008, fechaImposicion = new DateTime(2026, 04, 12), CDOrigenId = 15, CDDestinoId = 16, tamaño = "L",  estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 9,  clienteID = 3, numeroGuia = 009, fechaImposicion = new DateTime(2026, 04, 13), CDOrigenId = 17, CDDestinoId = 18, tamaño = "M",  estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "D", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 10, clienteID = 4, numeroGuia = 010, fechaImposicion = new DateTime(2026, 04, 14), CDOrigenId = 17, CDDestinoId = 1,  tamaño = "S",  estadoGuia = "ADMITIDA", tipoImposicion = "A", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 11, clienteID = 1, numeroGuia = 011, fechaImposicion = new DateTime(2026, 04, 15), CDOrigenId = 1,  CDDestinoId = 2,  tamaño = "XL", estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 12, clienteID = 2, numeroGuia = 012, fechaImposicion = new DateTime(2026, 04, 16), CDOrigenId = 3,  CDDestinoId = 4,  tamaño = "L",  estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 13, clienteID = 3, numeroGuia = 013, fechaImposicion = new DateTime(2026, 04, 17), CDOrigenId = 5,  CDDestinoId = 6,  tamaño = "M",  estadoGuia = "RENDIDA", tipoImposicion = "C", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 14, clienteID = 4, numeroGuia = 014, fechaImposicion = new DateTime(2026, 04, 18), CDOrigenId = 7,  CDDestinoId = 8,  tamaño = "S",  estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 15, clienteID = 1, numeroGuia = 015, fechaImposicion = new DateTime(2026, 04, 19), CDOrigenId = 9,  CDDestinoId = 10, tamaño = "XL", estadoGuia = "ADMITIDA", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 16, clienteID = 2, numeroGuia = 016, fechaImposicion = new DateTime(2026, 04, 20), CDOrigenId = 11, CDDestinoId = 12, tamaño = "L",  estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 17, clienteID = 3, numeroGuia = 017, fechaImposicion = new DateTime(2026, 04, 21), CDOrigenId = 13, CDDestinoId = 14, tamaño = "M",  estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "C", tipoEntrega = "C", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 18, clienteID = 4, numeroGuia = 018, fechaImposicion = new DateTime(2026, 04, 22), CDOrigenId = 15, CDDestinoId = 16, tamaño = "S",  estadoGuia = "RENDIDA", tipoImposicion = "A", tipoEntrega = "D", tarifarioId = 1 },
            new GuiasAAdmitir { Id = 19, clienteID = 5, numeroGuia = 019, fechaImposicion = new DateTime(2026, 04, 23), CDOrigenId = 17, CDDestinoId = 18, tamaño = "XL", estadoGuia = "IMPUESTA_TELEFONICAMENTE", tipoImposicion = "C", tipoEntrega = "A", tarifarioId = 1 },
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
            new Tarifario { TarifarioId = 1, TarifaImposicionAgencia = 5000, TarifaRetiroDomicilio = 10000, TarifaEntregaAgencia = 5000, TarifaDistribucionDomicilio = 10000, TarifaUnitarioTransporte = 10 }
        };
        public List<TarifaTransporte> LTarifasTransporte => new List<TarifaTransporte>
        {
            // Buenos Aires (1)
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 2,  CoeficienteS = 300,  CoeficienteM = 600,  CoeficienteL = 1200, CoeficienteXL = 2400  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 3,  CoeficienteS = 700,  CoeficienteM = 1400, CoeficienteL = 2800, CoeficienteXL = 5600  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 4,  CoeficienteS = 1050, CoeficienteM = 2100, CoeficienteL = 4200, CoeficienteXL = 8400  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 5,  CoeficienteS = 60,   CoeficienteM = 120,  CoeficienteL = 240,  CoeficienteXL = 480   },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 6,  CoeficienteS = 415,  CoeficienteM = 830,  CoeficienteL = 1660, CoeficienteXL = 3320  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 7,  CoeficienteS = 1100, CoeficienteM = 2200, CoeficienteL = 4400, CoeficienteXL = 8800  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 8,  CoeficienteS = 1490, CoeficienteM = 2980, CoeficienteL = 5960, CoeficienteXL = 11920 },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 9,  CoeficienteS = 1150, CoeficienteM = 2300, CoeficienteL = 4600, CoeficienteXL = 9200  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 10, CoeficienteS = 640,  CoeficienteM = 1280, CoeficienteL = 2560, CoeficienteXL = 5120  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 11, CoeficienteS = 1250, CoeficienteM = 2500, CoeficienteL = 5000, CoeficienteXL = 10000 },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 12, CoeficienteS = 470,  CoeficienteM = 940,  CoeficienteL = 1880, CoeficienteXL = 3760  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 13, CoeficienteS = 920,  CoeficienteM = 1840, CoeficienteL = 3680, CoeficienteXL = 7360  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 14, CoeficienteS = 1000, CoeficienteM = 2000, CoeficienteL = 4000, CoeficienteXL = 8000  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 15, CoeficienteS = 930,  CoeficienteM = 1860, CoeficienteL = 3720, CoeficienteXL = 7440  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 16, CoeficienteS = 790,  CoeficienteM = 1580, CoeficienteL = 3160, CoeficienteXL = 6320  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 17, CoeficienteS = 1130, CoeficienteM = 2260, CoeficienteL = 4520, CoeficienteXL = 9040  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 18, CoeficienteS = 1500, CoeficienteM = 3000, CoeficienteL = 6000, CoeficienteXL = 12000 },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 19, CoeficienteS = 1150, CoeficienteM = 2300, CoeficienteL = 4600, CoeficienteXL = 9200  },
            new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 20, CoeficienteS = 1180, CoeficienteM = 2360, CoeficienteL = 4720, CoeficienteXL = 9440  },
            // Rosario (2)
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 3,  CoeficienteS = 400,  CoeficienteM = 800,  CoeficienteL = 1600, CoeficienteXL = 3200  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 4,  CoeficienteS = 850,  CoeficienteM = 1700, CoeficienteL = 3400, CoeficienteXL = 6800  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 5,  CoeficienteS = 350,  CoeficienteM = 700,  CoeficienteL = 1400, CoeficienteXL = 2800  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 6,  CoeficienteS = 710,  CoeficienteM = 1420, CoeficienteL = 2840, CoeficienteXL = 5680  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 7,  CoeficienteS = 900,  CoeficienteM = 1800, CoeficienteL = 3600, CoeficienteXL = 7200  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 8,  CoeficienteS = 1200, CoeficienteM = 2400, CoeficienteL = 4800, CoeficienteXL = 9600  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 9,  CoeficienteS = 1100, CoeficienteM = 2200, CoeficienteL = 4400, CoeficienteXL = 8800  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 10, CoeficienteS = 760,  CoeficienteM = 1520, CoeficienteL = 3040, CoeficienteXL = 6080  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 11, CoeficienteS = 950,  CoeficienteM = 1900, CoeficienteL = 3800, CoeficienteXL = 7600  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 12, CoeficienteS = 170,  CoeficienteM = 340,  CoeficienteL = 680,  CoeficienteXL = 1360  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 13, CoeficienteS = 630,  CoeficienteM = 1260, CoeficienteL = 2520, CoeficienteXL = 5040  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 14, CoeficienteS = 800,  CoeficienteM = 1600, CoeficienteL = 3200, CoeficienteXL = 6400  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 15, CoeficienteS = 640,  CoeficienteM = 1280, CoeficienteL = 2560, CoeficienteXL = 5120  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 16, CoeficienteS = 610,  CoeficienteM = 1220, CoeficienteL = 2440, CoeficienteXL = 4880  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 17, CoeficienteS = 830,  CoeficienteM = 1660, CoeficienteL = 3320, CoeficienteXL = 6640  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 18, CoeficienteS = 1210, CoeficienteM = 2420, CoeficienteL = 4840, CoeficienteXL = 9680  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 19, CoeficienteS = 850,  CoeficienteM = 1700, CoeficienteL = 3400, CoeficienteXL = 6800  },
            new TarifaTransporte { CDOrigenId = 2, CDDestinoId = 20, CoeficienteS = 890,  CoeficienteM = 1780, CoeficienteL = 3560, CoeficienteXL = 7120  },
            // Córdoba (3)
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 4,  CoeficienteS = 610,  CoeficienteM = 1220, CoeficienteL = 2440, CoeficienteXL = 4880  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 5,  CoeficienteS = 760,  CoeficienteM = 1520, CoeficienteL = 3040, CoeficienteXL = 6080  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 6,  CoeficienteS = 1100, CoeficienteM = 2200, CoeficienteL = 4400, CoeficienteXL = 8800  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 7,  CoeficienteS = 580,  CoeficienteM = 1160, CoeficienteL = 2320, CoeficienteXL = 4640  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 8,  CoeficienteS = 890,  CoeficienteM = 1780, CoeficienteL = 3560, CoeficienteXL = 7120  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 9,  CoeficienteS = 1100, CoeficienteM = 2200, CoeficienteL = 4400, CoeficienteXL = 8800  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 10, CoeficienteS = 1050, CoeficienteM = 2100, CoeficienteL = 4200, CoeficienteXL = 8400  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 11, CoeficienteS = 550,  CoeficienteM = 1100, CoeficienteL = 2200, CoeficienteXL = 4400  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 12, CoeficienteS = 350,  CoeficienteM = 700,  CoeficienteL = 1400, CoeficienteXL = 2800  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 13, CoeficienteS = 900,  CoeficienteM = 1800, CoeficienteL = 3600, CoeficienteXL = 7200  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 14, CoeficienteS = 1100, CoeficienteM = 2200, CoeficienteL = 4400, CoeficienteXL = 8800  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 15, CoeficienteS = 850,  CoeficienteM = 1700, CoeficienteL = 3400, CoeficienteXL = 6800  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 16, CoeficienteS = 430,  CoeficienteM = 860,  CoeficienteL = 1720, CoeficienteXL = 3440  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 17, CoeficienteS = 440,  CoeficienteM = 880,  CoeficienteL = 1760, CoeficienteXL = 3520  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 18, CoeficienteS = 910,  CoeficienteM = 1820, CoeficienteL = 3640, CoeficienteXL = 7280  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 19, CoeficienteS = 450,  CoeficienteM = 900,  CoeficienteL = 1800, CoeficienteXL = 3600  },
            new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 20, CoeficienteS = 1100, CoeficienteM = 2200, CoeficienteL = 4400, CoeficienteXL = 8800  },
            // Mendoza (4)
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 5,  CoeficienteS = 1100, CoeficienteM = 2200, CoeficienteL = 4400, CoeficienteXL = 8800  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 6,  CoeficienteS = 1350, CoeficienteM = 2700, CoeficienteL = 5400, CoeficienteXL = 10800 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 7,  CoeficienteS = 170,  CoeficienteM = 340,  CoeficienteL = 680,  CoeficienteXL = 1360  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 8,  CoeficienteS = 1240, CoeficienteM = 2480, CoeficienteL = 4960, CoeficienteXL = 9920  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 9,  CoeficienteS = 800,  CoeficienteM = 1600, CoeficienteL = 3200, CoeficienteXL = 6400  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 10, CoeficienteS = 1200, CoeficienteM = 2400, CoeficienteL = 4800, CoeficienteXL = 9600  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 11, CoeficienteS = 950,  CoeficienteM = 1900, CoeficienteL = 3800, CoeficienteXL = 7600  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 12, CoeficienteS = 900,  CoeficienteM = 1800, CoeficienteL = 3600, CoeficienteXL = 7200  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 13, CoeficienteS = 1400, CoeficienteM = 2800, CoeficienteL = 5600, CoeficienteXL = 11200 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 14, CoeficienteS = 1600, CoeficienteM = 3200, CoeficienteL = 6400, CoeficienteXL = 12800 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 15, CoeficienteS = 1350, CoeficienteM = 2700, CoeficienteL = 5400, CoeficienteXL = 10800 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 16, CoeficienteS = 260,  CoeficienteM = 520,  CoeficienteL = 1040, CoeficienteXL = 2080  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 17, CoeficienteS = 750,  CoeficienteM = 1500, CoeficienteL = 3000, CoeficienteXL = 6000  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 18, CoeficienteS = 1300, CoeficienteM = 2600, CoeficienteL = 5200, CoeficienteXL = 10400 },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 19, CoeficienteS = 450,  CoeficienteM = 900,  CoeficienteL = 1800, CoeficienteXL = 3600  },
            new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 20, CoeficienteS = 1600, CoeficienteM = 3200, CoeficienteL = 6400, CoeficienteXL = 12800 },
            // La Plata (5)
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 6,  CoeficienteS = 365,  CoeficienteM = 730,  CoeficienteL = 1460, CoeficienteXL = 2920  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 7,  CoeficienteS = 1150, CoeficienteM = 2300, CoeficienteL = 4600, CoeficienteXL = 9200  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 8,  CoeficienteS = 1550, CoeficienteM = 3100, CoeficienteL = 6200, CoeficienteXL = 12400 },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 9,  CoeficienteS = 1140, CoeficienteM = 2280, CoeficienteL = 4560, CoeficienteXL = 9120  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 10, CoeficienteS = 630,  CoeficienteM = 1260, CoeficienteL = 2520, CoeficienteXL = 5040  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 11, CoeficienteS = 1300, CoeficienteM = 2600, CoeficienteL = 5200, CoeficienteXL = 10400 },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 12, CoeficienteS = 520,  CoeficienteM = 1040, CoeficienteL = 2080, CoeficienteXL = 4160  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 13, CoeficienteS = 970,  CoeficienteM = 1940, CoeficienteL = 3880, CoeficienteXL = 7760  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 14, CoeficienteS = 1050, CoeficienteM = 2100, CoeficienteL = 4200, CoeficienteXL = 8400  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 15, CoeficienteS = 980,  CoeficienteM = 1960, CoeficienteL = 3920, CoeficienteXL = 7840  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 16, CoeficienteS = 840,  CoeficienteM = 1680, CoeficienteL = 3360, CoeficienteXL = 6720  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 17, CoeficienteS = 1180, CoeficienteM = 2360, CoeficienteL = 4720, CoeficienteXL = 9440  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 18, CoeficienteS = 1560, CoeficienteM = 3120, CoeficienteL = 6240, CoeficienteXL = 12480 },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 19, CoeficienteS = 1200, CoeficienteM = 2400, CoeficienteL = 4800, CoeficienteXL = 9600  },
            new TarifaTransporte { CDOrigenId = 5, CDDestinoId = 20, CoeficienteS = 1230, CoeficienteM = 2460, CoeficienteL = 4920, CoeficienteXL = 9840  },
            // Mar del Plata (6)
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 7,  CoeficienteS = 1400, CoeficienteM = 2800, CoeficienteL = 5600, CoeficienteXL = 11200 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 8,  CoeficienteS = 1900, CoeficienteM = 3800, CoeficienteL = 7600, CoeficienteXL = 15200 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 9,  CoeficienteS = 1050, CoeficienteM = 2100, CoeficienteL = 4200, CoeficienteXL = 8400  },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 10, CoeficienteS = 450,  CoeficienteM = 900,  CoeficienteL = 1800, CoeficienteXL = 3600  },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 11, CoeficienteS = 1650, CoeficienteM = 3300, CoeficienteL = 6600, CoeficienteXL = 13200 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 12, CoeficienteS = 880,  CoeficienteM = 1760, CoeficienteL = 3520, CoeficienteXL = 7040  },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 13, CoeficienteS = 1330, CoeficienteM = 2660, CoeficienteL = 5320, CoeficienteXL = 10640 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 14, CoeficienteS = 1410, CoeficienteM = 2820, CoeficienteL = 5640, CoeficienteXL = 11280 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 15, CoeficienteS = 1340, CoeficienteM = 2680, CoeficienteL = 5360, CoeficienteXL = 10720 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 16, CoeficienteS = 1100, CoeficienteM = 2200, CoeficienteL = 4400, CoeficienteXL = 8800  },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 17, CoeficienteS = 1540, CoeficienteM = 3080, CoeficienteL = 6160, CoeficienteXL = 12320 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 18, CoeficienteS = 1910, CoeficienteM = 3820, CoeficienteL = 7640, CoeficienteXL = 15280 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 19, CoeficienteS = 1450, CoeficienteM = 2900, CoeficienteL = 5800, CoeficienteXL = 11600 },
            new TarifaTransporte { CDOrigenId = 6, CDDestinoId = 20, CoeficienteS = 1590, CoeficienteM = 3180, CoeficienteL = 6360, CoeficienteXL = 12720 },
            // San Juan (7)
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 8,  CoeficienteS = 1080, CoeficienteM = 2160, CoeficienteL = 4320, CoeficienteXL = 8640  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 9,  CoeficienteS = 950,  CoeficienteM = 1900, CoeficienteL = 3800, CoeficienteXL = 7600  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 10, CoeficienteS = 1350, CoeficienteM = 2700, CoeficienteL = 5400, CoeficienteXL = 10800 },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 11, CoeficienteS = 800,  CoeficienteM = 1600, CoeficienteL = 3200, CoeficienteXL = 6400  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 12, CoeficienteS = 950,  CoeficienteM = 1900, CoeficienteL = 3800, CoeficienteXL = 7600  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 13, CoeficienteS = 1350, CoeficienteM = 2700, CoeficienteL = 5400, CoeficienteXL = 10800 },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 14, CoeficienteS = 1550, CoeficienteM = 3100, CoeficienteL = 6200, CoeficienteXL = 12400 },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 15, CoeficienteS = 1300, CoeficienteM = 2600, CoeficienteL = 5200, CoeficienteXL = 10400 },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 16, CoeficienteS = 320,  CoeficienteM = 640,  CoeficienteL = 1280, CoeficienteXL = 2560  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 17, CoeficienteS = 600,  CoeficienteM = 1200, CoeficienteL = 2400, CoeficienteXL = 4800  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 18, CoeficienteS = 1150, CoeficienteM = 2300, CoeficienteL = 4600, CoeficienteXL = 9200  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 19, CoeficienteS = 440,  CoeficienteM = 880,  CoeficienteL = 1760, CoeficienteXL = 3520  },
            new TarifaTransporte { CDOrigenId = 7, CDDestinoId = 20, CoeficienteS = 1550, CoeficienteM = 3100, CoeficienteL = 6200, CoeficienteXL = 12400 },
            // Salta (8)
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 9,  CoeficienteS = 2050, CoeficienteM = 4100, CoeficienteL = 8200, CoeficienteXL = 16400 },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 10, CoeficienteS = 1900, CoeficienteM = 3800, CoeficienteL = 7600, CoeficienteXL = 15200 },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 11, CoeficienteS = 310,  CoeficienteM = 620,  CoeficienteL = 1240, CoeficienteXL = 2480  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 12, CoeficienteS = 1030, CoeficienteM = 2060, CoeficienteL = 4120, CoeficienteXL = 8240  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 13, CoeficienteS = 830,  CoeficienteM = 1660, CoeficienteL = 3320, CoeficienteXL = 6640  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 14, CoeficienteS = 1030, CoeficienteM = 2060, CoeficienteL = 4120, CoeficienteXL = 8240  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 15, CoeficienteS = 820,  CoeficienteM = 1640, CoeficienteL = 3280, CoeficienteXL = 6560  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 16, CoeficienteS = 1150, CoeficienteM = 2300, CoeficienteL = 4600, CoeficienteXL = 9200  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 17, CoeficienteS = 520,  CoeficienteM = 1040, CoeficienteL = 2080, CoeficienteXL = 4160  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 18, CoeficienteS = 90,   CoeficienteM = 180,  CoeficienteL = 360,  CoeficienteXL = 720   },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 19, CoeficienteS = 670,  CoeficienteM = 1340, CoeficienteL = 2680, CoeficienteXL = 5360  },
            new TarifaTransporte { CDOrigenId = 8, CDDestinoId = 20, CoeficienteS = 1000, CoeficienteM = 2000, CoeficienteL = 4000, CoeficienteXL = 8000  },
            // Neuquén (9)
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 10, CoeficienteS = 540,  CoeficienteM = 1080, CoeficienteL = 2160, CoeficienteXL = 4320  },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 11, CoeficienteS = 1750, CoeficienteM = 3500, CoeficienteL = 7000, CoeficienteXL = 14000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 12, CoeficienteS = 1250, CoeficienteM = 2500, CoeficienteL = 5000, CoeficienteXL = 10000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 13, CoeficienteS = 1950, CoeficienteM = 3900, CoeficienteL = 7800, CoeficienteXL = 15600 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 14, CoeficienteS = 2100, CoeficienteM = 4200, CoeficienteL = 8400, CoeficienteXL = 16800 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 15, CoeficienteS = 1900, CoeficienteM = 3800, CoeficienteL = 7600, CoeficienteXL = 15200 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 16, CoeficienteS = 850,  CoeficienteM = 1700, CoeficienteL = 3400, CoeficienteXL = 6800  },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 17, CoeficienteS = 1550, CoeficienteM = 3100, CoeficienteL = 6200, CoeficienteXL = 12400 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 18, CoeficienteS = 2100, CoeficienteM = 4200, CoeficienteL = 8400, CoeficienteXL = 16800 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 19, CoeficienteS = 1250, CoeficienteM = 2500, CoeficienteL = 5000, CoeficienteXL = 10000 },
            new TarifaTransporte { CDOrigenId = 9, CDDestinoId = 20, CoeficienteS = 2150, CoeficienteM = 4300, CoeficienteL = 8600, CoeficienteXL = 17200 },
            // Bahía Blanca (10)
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 11, CoeficienteS = 1600, CoeficienteM = 3200, CoeficienteL = 6400, CoeficienteXL = 12800 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 12, CoeficienteS = 930,  CoeficienteM = 1860, CoeficienteL = 3720, CoeficienteXL = 7440  },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 13, CoeficienteS = 1450, CoeficienteM = 2900, CoeficienteL = 5800, CoeficienteXL = 11600 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 14, CoeficienteS = 1550, CoeficienteM = 3100, CoeficienteL = 6200, CoeficienteXL = 12400 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 15, CoeficienteS = 1400, CoeficienteM = 2800, CoeficienteL = 5600, CoeficienteXL = 11200 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 16, CoeficienteS = 900,  CoeficienteM = 1800, CoeficienteL = 3600, CoeficienteXL = 7200  },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 17, CoeficienteS = 1450, CoeficienteM = 2900, CoeficienteL = 5800, CoeficienteXL = 11600 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 18, CoeficienteS = 1950, CoeficienteM = 3900, CoeficienteL = 7800, CoeficienteXL = 15600 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 19, CoeficienteS = 1350, CoeficienteM = 2700, CoeficienteL = 5400, CoeficienteXL = 10800 },
            new TarifaTransporte { CDOrigenId = 10, CDDestinoId = 20, CoeficienteS = 1650, CoeficienteM = 3300, CoeficienteL = 6600, CoeficienteXL = 13200 },
            // Tucumán (11)
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 12, CoeficienteS = 780,  CoeficienteM = 1560, CoeficienteL = 3120, CoeficienteXL = 6240  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 13, CoeficienteS = 750,  CoeficienteM = 1500, CoeficienteL = 3000, CoeficienteXL = 6000  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 14, CoeficienteS = 950,  CoeficienteM = 1900, CoeficienteL = 3800, CoeficienteXL = 7600  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 15, CoeficienteS = 740,  CoeficienteM = 1480, CoeficienteL = 2960, CoeficienteXL = 5920  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 16, CoeficienteS = 850,  CoeficienteM = 1700, CoeficienteL = 3400, CoeficienteXL = 6800  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 17, CoeficienteS = 230,  CoeficienteM = 460,  CoeficienteL = 920,  CoeficienteXL = 1840  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 18, CoeficienteS = 340,  CoeficienteM = 680,  CoeficienteL = 1360, CoeficienteXL = 2720  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 19, CoeficienteS = 440,  CoeficienteM = 880,  CoeficienteL = 1760, CoeficienteXL = 3520  },
            new TarifaTransporte { CDOrigenId = 11, CDDestinoId = 20, CoeficienteS = 920,  CoeficienteM = 1840, CoeficienteL = 3680, CoeficienteXL = 7360  },
            // Santa Fe (12)
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 13, CoeficienteS = 560,  CoeficienteM = 1120, CoeficienteL = 2240, CoeficienteXL = 4480  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 14, CoeficienteS = 740,  CoeficienteM = 1480, CoeficienteL = 2960, CoeficienteXL = 5920  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 15, CoeficienteS = 540,  CoeficienteM = 1080, CoeficienteL = 2160, CoeficienteXL = 4320  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 16, CoeficienteS = 650,  CoeficienteM = 1300, CoeficienteL = 2600, CoeficienteXL = 5200  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 17, CoeficienteS = 660,  CoeficienteM = 1320, CoeficienteL = 2640, CoeficienteXL = 5280  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 18, CoeficienteS = 1040, CoeficienteM = 2080, CoeficienteL = 4160, CoeficienteXL = 8320  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 19, CoeficienteS = 700,  CoeficienteM = 1400, CoeficienteL = 2800, CoeficienteXL = 5600  },
            new TarifaTransporte { CDOrigenId = 12, CDDestinoId = 20, CoeficienteS = 800,  CoeficienteM = 1600, CoeficienteL = 3200, CoeficienteXL = 6400  },
            // Corrientes (13)
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 14, CoeficienteS = 320,  CoeficienteM = 640,  CoeficienteL = 1280, CoeficienteXL = 2560  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 15, CoeficienteS = 20,   CoeficienteM = 40,   CoeficienteL = 80,   CoeficienteXL = 160   },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 16, CoeficienteS = 1150, CoeficienteM = 2300, CoeficienteL = 4600, CoeficienteXL = 9200  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 17, CoeficienteS = 850,  CoeficienteM = 1700, CoeficienteL = 3400, CoeficienteXL = 6800  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 18, CoeficienteS = 860,  CoeficienteM = 1720, CoeficienteL = 3440, CoeficienteXL = 6880  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 19, CoeficienteS = 1000, CoeficienteM = 2000, CoeficienteL = 4000, CoeficienteXL = 8000  },
            new TarifaTransporte { CDOrigenId = 13, CDDestinoId = 20, CoeficienteS = 190,  CoeficienteM = 380,  CoeficienteL = 760,  CoeficienteXL = 1520  },
            // Posadas (14)
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 15, CoeficienteS = 340,  CoeficienteM = 680,  CoeficienteL = 1360, CoeficienteXL = 2720  },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 16, CoeficienteS = 1350, CoeficienteM = 2700, CoeficienteL = 5400, CoeficienteXL = 10800 },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 17, CoeficienteS = 1050, CoeficienteM = 2100, CoeficienteL = 4200, CoeficienteXL = 8400  },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 18, CoeficienteS = 1060, CoeficienteM = 2120, CoeficienteL = 4240, CoeficienteXL = 8480  },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 19, CoeficienteS = 1200, CoeficienteM = 2400, CoeficienteL = 4800, CoeficienteXL = 9600  },
            new TarifaTransporte { CDOrigenId = 14, CDDestinoId = 20, CoeficienteS = 310,  CoeficienteM = 620,  CoeficienteL = 1240, CoeficienteXL = 2480  },
            // Resistencia (15)
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 16, CoeficienteS = 1150, CoeficienteM = 2300, CoeficienteL = 4600, CoeficienteXL = 9200  },
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 17, CoeficienteS = 840,  CoeficienteM = 1680, CoeficienteL = 3360, CoeficienteXL = 6720  },
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 18, CoeficienteS = 850,  CoeficienteM = 1700, CoeficienteL = 3400, CoeficienteXL = 6800  },
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 19, CoeficienteS = 990,  CoeficienteM = 1980, CoeficienteL = 3960, CoeficienteXL = 7920  },
            new TarifaTransporte { CDOrigenId = 15, CDDestinoId = 20, CoeficienteS = 170,  CoeficienteM = 340,  CoeficienteL = 680,  CoeficienteXL = 1360  },
            // San Luis (16)
            new TarifaTransporte { CDOrigenId = 16, CDDestinoId = 17, CoeficienteS = 650,  CoeficienteM = 1300, CoeficienteL = 2600, CoeficienteXL = 5200  },
            new TarifaTransporte { CDOrigenId = 16, CDDestinoId = 18, CoeficienteS = 1200, CoeficienteM = 2400, CoeficienteL = 4800, CoeficienteXL = 9600  },
            new TarifaTransporte { CDOrigenId = 16, CDDestinoId = 19, CoeficienteS = 450,  CoeficienteM = 900,  CoeficienteL = 1800, CoeficienteXL = 3600  },
            new TarifaTransporte { CDOrigenId = 16, CDDestinoId = 20, CoeficienteS = 1320, CoeficienteM = 2640, CoeficienteL = 5280, CoeficienteXL = 10560 },
            // Catamarca (17)
            new TarifaTransporte { CDOrigenId = 17, CDDestinoId = 18, CoeficienteS = 440,  CoeficienteM = 880,  CoeficienteL = 1760, CoeficienteXL = 3520  },
            new TarifaTransporte { CDOrigenId = 17, CDDestinoId = 19, CoeficienteS = 150,  CoeficienteM = 300,  CoeficienteL = 600,  CoeficienteXL = 1200  },
            new TarifaTransporte { CDOrigenId = 17, CDDestinoId = 20, CoeficienteS = 1010, CoeficienteM = 2020, CoeficienteL = 4040, CoeficienteXL = 8080  },
            // Jujuy (18)
            new TarifaTransporte { CDOrigenId = 18, CDDestinoId = 19, CoeficienteS = 600,  CoeficienteM = 1200, CoeficienteL = 2400, CoeficienteXL = 4800  },
            new TarifaTransporte { CDOrigenId = 18, CDDestinoId = 20, CoeficienteS = 1030, CoeficienteM = 2060, CoeficienteL = 4120, CoeficienteXL = 8240  },
            // La Rioja (19)
            new TarifaTransporte { CDOrigenId = 19, CDDestinoId = 20, CoeficienteS = 1160, CoeficienteM = 2320, CoeficienteL = 4640, CoeficienteXL = 9280  },
        };
        public int ObtenerCoeficiente(int origenId, int destinoId, string tipoCaja)
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
        public decimal ObtenerTarifaImposicionAgencia(int tarifarioId)
        {
            foreach (var tarifa in LTarifarios)
            {
                if (tarifarioId == tarifa.TarifarioId)
                { return tarifa.TarifaImposicionAgencia; }
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
