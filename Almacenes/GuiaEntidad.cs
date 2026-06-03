namespace GrupoE_Tutasa.Almacenes
{
    public enum EstadoGuiaEnum
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

    public enum ModalidadImposicionEnum
    {
        AGENCIA,
        CD,
        DOMICILIO
    }

    public enum ModalidadEntregaEnum
    {
        AGENCIA,
        CD,
        DOMICILIO
    }

    public enum TipoCajaEnum
    {
        S,
        M,
        L,
        XL
    }

    public class GuiaEntidad
    {
        public int GuiaId { get; set; }
        public int ClienteId { get; set; }
        public int AgenciaOrigenId { get; set; }
        public int AgenciaDestinoId { get; set; }
        public int CDOrigenId { get; set; }
        public int CDDestinoId { get; set; }
        public ModalidadImposicionEnum ModalidadImposicion { get; set; }
        public Domicilio DomicilioRetiro { get; set; }
        public ModalidadEntregaEnum ModalidadEntrega { get; set; }
        public string NombreDestinatario { get; set; }
        public string ApellidoDestinatario { get; set; }
        public int DniDestinatario { get; set; }
        public TipoCajaEnum TipoCaja { get; set; }
        public Domicilio DomicilioEntrega { get; set; }
        public int IntentosDeEntrega { get; set; }
        public int CDActualId { get; set; }
        public EstadoGuiaEnum Estado { get; set; }
        public int TarifarioId { get; set; }
        public string ObservacionesAdmision { get; set; }
    }
}
