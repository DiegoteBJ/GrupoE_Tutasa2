namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// OV.1 - Objeto de Valor: Domicilio
    /// </summary>
    internal class Domicilio
    {
        public string Calle        { get; set; } = string.Empty;
        public string Numero       { get; set; } = string.Empty;
        public string Piso         { get; set; } = string.Empty;   // opcional
        public string Depto        { get; set; } = string.Empty;   // opcional
        public string CodigoPostal { get; set; } = string.Empty;
        public int    LocalidadId  { get; set; }                   // FK → AL.21
    }
}
