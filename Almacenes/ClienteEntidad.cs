namespace GrupoE_Tutasa.Almacenes
{
    public class ClienteEntidad
    {
        public int ClienteId { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cuit { get; set; }
        public Domicilio Domicilio { get; set; }
        public string Telefono { get; set; }
    }
}
