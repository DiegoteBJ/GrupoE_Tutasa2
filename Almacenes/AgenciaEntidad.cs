using System.Collections.Generic;

namespace GrupoE_Tutasa.Almacenes
{
    public class AgenciaEntidad
    {
        public int AgenciaId { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cuit { get; set; }
        public Domicilio Domicilio { get; set; }
        public int CDAsignadoId { get; set; }
        public decimal MontoFijoComisionRecepcion { get; set; }
        public decimal MontoFijoComisionEntrega { get; set; }
        public List<string> CodigosPostalesCobertura { get; set; }
    }
}
