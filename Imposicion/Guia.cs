namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// AL.14 - Guías
    /// Representa una encomienda individual con su trazabilidad completa.
    /// </summary>
    internal class Guia
    {
        public int    GuiaId          { get; set; }   // PK
        public int    ClienteId       { get; set; }   // FK → AL.1

        // ── Origen ──
        public int?   AgenciaOrigenId { get; set; }   // FK → AL.3  (si modalidad = AGENCIA)
        public int    CDOrigenId      { get; set; }   // FK → AL.18
        public int    CDDestinoId     { get; set; }   // FK → AL.18

        /// <summary>
        /// Regla de negocio: se registra SOLO cuando la imposición es en CD (ModalidadImposicion == CD).
        /// Para imposición telefónica (DOMICILIO) y en agencia (AGENCIA) queda en null.
        /// </summary>
        public int?   CDActualId      { get; set; }   // FK → AL.18

        // ── Modalidades ──
        public ModalidadImposicionEnum ModalidadImposicion { get; set; }
        public Domicilio?              DomicilioRetiro     { get; set; }

        public ModalidadEntregaEnum    ModalidadEntrega    { get; set; }
        public int?   AgenciaDestinoId { get; set; }   // FK → AL.3  (si modalidad entrega = AGENCIA)
        public Domicilio?              DomicilioEntrega    { get; set; }

        // ── Destinatario ──
        public string NombreDestinatario   { get; set; } = string.Empty;
        public string ApellidoDestinatario { get; set; } = string.Empty;
        public int    DNIDestinatario      { get; set; }

        // ── Encomienda ──
        public TipoCajaEnum TipoCaja { get; set; }

        // ── Control y estado ──
        public int            IntentosDeEntrega    { get; set; }
        public EstadoGuiaEnum Estado               { get; set; }
        public int            TarifarioId          { get; set; }   // FK → AL.2.1
        public string         ObservacionesAdmision { get; set; } = string.Empty;

        // ── Fecha de imposición (asignada al registrar) ──
        public DateTime FechaImposicion { get; set; }
    }
}
