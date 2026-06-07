namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// AL.1 - Padrón de Clientes
    /// </summary>
    internal class ClienteRemitente
    {
        public int      ClienteId   { get; set; }   // PK
        public string   RazonSocial { get; set; }
        public string   Nombre      { get; set; }
        public string   Apellido    { get; set; }
        public string   CUIT        { get; set; }
        public Domicilio Domicilio  { get; set; }
        public string   Telefono    { get; set; }
    }
}
