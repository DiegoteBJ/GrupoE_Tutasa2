namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// AL.3 - Padrón de Agencias
    /// </summary>
    internal class Agencia
    {
        public int       AgenciaId                  { get; set; }           // PK
        public string    RazonSocial                { get; set; } = string.Empty;
        public string    Nombre                     { get; set; } = string.Empty;
        public string    Apellido                   { get; set; } = string.Empty;
        public string    CUIT                       { get; set; } = string.Empty;
        public Domicilio? Domicilio                 { get; set; }
        public string    Telefono                   { get; set; } = string.Empty;
        public int       CDAsignadoId               { get; set; }           // FK → AL.18
        public decimal   MontoFijoComisionRecepcion { get; set; }
        public decimal   MontoFijoComisionEntrega   { get; set; }
        public List<string> CodigosPostalesCobertura { get; set; } = new();
    }
}
