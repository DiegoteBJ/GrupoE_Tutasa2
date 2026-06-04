namespace GrupoE_Tutasa.Almacenes
{
    public enum TipoArrendamientoEnum
    {
        A,
        B,
        C,
        D
    }

    public class RutasCobertura
    {
        public int CDOrigenId { get; set; }
        public int CDDestinoId { get; set; }
        public TipoArrendamientoEnum TipoArrendamiento { get; set; }
    }
}
