using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.GenerarHDR
{
    internal enum EstadoGuiaEnume
    {
        A_RETIRAR,
        RENDIDA,
        ADMITIDA,
        CANCELADA,
        PENDIENTE_2DO_INTENTO,
        TRASLADADA,
        EN_CD_DESTINO,
        EN_DISTRIBUCION,
        PENDIENTE_DE_ENTREGA,
        ENTREGADA
    }

    internal enum ModalidadImposicionEnume
    {
        AGENCIA,
        CD,
        DOMICILIO
    }

    internal enum ModalidadEntregaEnume
    {
        AGENCIA,
        CD,
        DOMICILIO
    }

    internal enum TipoCajaEnume
    {
        S,
        M,
        L,
        XL
    }

    internal class Guia
    {
        public int GuiaId { get; set; }
        public int ClienteId { get; set; }
        public int AgenciaOrigenId { get; set; }
        public int AgenciaDestinoId { get; set; }
        public int CDOrigenId { get; set; }
        public int CDDestinoId { get; set; }
        public ModalidadImposicionEnume ModalidadImposicion { get; set; }
        public Domicilios DomicilioRetiro { get; set; }
        public ModalidadEntregaEnume ModalidadEntrega { get; set; }
        public string NombreDestinatario { get; set; }
        public string ApellidoDestinatario { get; set; }
        public int DniDestinatario { get; set; }
        public TipoCajaEnume TipoCaja { get; set; }
        public Domicilios DomicilioEntrega { get; set; }
        public int IntentosDeEntrega { get; set; }
        public int CDActualId { get; set; }
        public EstadoGuiaEnume Estado { get; set; }
        public int TarifarioId { get; set; }
        public string ObservacionesAdmision { get; set; }
    }
}

