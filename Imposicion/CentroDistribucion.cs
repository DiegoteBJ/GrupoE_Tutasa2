namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// AL.18 - Padrón de Centros de Distribución
    /// </summary>
    internal class CentroDistribucion
    {
        public int        CDId      { get; set; }           // PK
        public string     Nombre    { get; set; } = string.Empty;
        public Domicilio? Domicilio { get; set; }
    }
}
