using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal enum EstadoGuiaEnum
    {
        A_RETIRAR,
        RENDIDA,
        ADMITIDA,
        CANCELADA,

        EN_CD_DESTINO,
        EN_DISTRIBUCION,
        PENDIENTE_DE_ENTREGA,
        ENTREGADA
    }

    internal enum ModalidadImposicionEnum
    {
        AGENCIA,
        CD,
        DOMICILIO
    }

    internal enum ModalidadEntregaEnum
    {
        AGENCIA,
        CD,
        DOMICILIO
    }

    internal enum TipoCajaEnum
    {
        S,
        M,
        L,
        XL
    }

    internal class Guias
    {
        public int GuiaId { get; set; }

        public ModalidadImposicionEnum ModalidadImposicion { get; set; }
        public Domicilio DomicilioRetiro { get; set; }
        public ModalidadEntregaEnum ModalidadEntrega { get; set; }
        public string NombreDestinatarioGuia { get; set; }
        public string ApellidoDestinatarioGuia { get; set; }
        public int DniDestinatario { get; set; }
        public TipoCajaEnum tamañoGuia { get; set; }
        public Domicilio DomicilioEntrega { get; set; }
        public int IntentosDeEntrega { get; set; }
        public int CDActualId { get; set; }
        public EstadoGuiaEnum EstadoGuia { get; set; }
       
    }
}

