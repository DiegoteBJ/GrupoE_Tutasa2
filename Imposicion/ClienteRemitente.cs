namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// AL.1 - Padrón de Clientes
    /// </summary>
    internal class ClienteRemitente
    {
        public int       ClienteId   { get; set; }          // PK
        public string    RazonSocial { get; set; } = string.Empty;
        public string    Nombre      { get; set; } = string.Empty;
        public string    Apellido    { get; set; } = string.Empty;
        public string    CUIT        { get; set; } = string.Empty;
        public Domicilio? Domicilio  { get; set; }
        public string    Telefono    { get; set; } = string.Empty;
    }
}
