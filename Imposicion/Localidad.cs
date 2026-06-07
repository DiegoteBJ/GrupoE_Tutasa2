namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// AL.21 - Localidades
    /// </summary>
    internal class Localidad
    {
        public int    LocalidadId          { get; set; }   // PK
        public int    ProvinciaId          { get; set; }   // FK → AL.22
        public string Nombre               { get; set; }
        public string CodigoPostalPrincipal { get; set; }
    }
}
