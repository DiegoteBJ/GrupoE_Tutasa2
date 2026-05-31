namespace GrupoE_Tutasa.Imposicion
{
    internal class Tarifa
    {
        public int     TarifaId           { get; set; }
        public string  Tipo               { get; set; }  // "S", "M", "L", "XL"
        public string  Descripcion        { get; set; }
        public decimal PrecioBase         { get; set; }
        public decimal PrecioKmAdicional  { get; set; }
    }
}
