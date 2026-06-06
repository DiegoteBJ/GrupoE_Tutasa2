namespace GrupoE_Tutasa.Imposicion
{
    /// <summary>
    /// OV.1 - Objeto de Valor: Domicilio
    /// </summary>
    internal class Domicilio
    {
        public string Calle         { get; set; }
        public string Numero        { get; set; }
        public string Piso          { get; set; }   // opcional
        public string Depto         { get; set; }   // opcional
        public string CodigoPostal  { get; set; }
        public int    LocalidadId   { get; set; }   // FK → AL.21
    }
}
