namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>Tipo de caja estandarizada.</summary>
    internal enum TipoCajaEnum
    {
        S,
        M,
        L,
        XL
    }

    /// <summary>Modalidad en que se impone la encomienda.</summary>
    internal enum ModalidadImposicionEnum
    {
        /// <summary>A – Imposición en agencia.</summary>
        AGENCIA,
        /// <summary>C – Imposición directa en CD.</summary>
        CD,
        /// <summary>D – Pedido de retiro a domicilio (telefónico).</summary>
        DOMICILIO
    }

    /// <summary>Modalidad de entrega al destinatario.</summary>
    internal enum ModalidadEntregaEnum
    {
        /// <summary>A – Retiro en agencia.</summary>
        AGENCIA,
        /// <summary>C – Retiro en CD.</summary>
        CD,
        /// <summary>D – Entrega a domicilio.</summary>
        DOMICILIO
    }

    /// <summary>Estados posibles de una guía (AL.14 *1).</summary>
    internal enum EstadoGuiaEnum
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
}
