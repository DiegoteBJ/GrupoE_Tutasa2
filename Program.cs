using GrupoE_Tutasa.GenerarHDR;
using GrupoE_Tutasa.GenerarHDRTransporte;

namespace GrupoE_Tutasa.FormularioPrincipal
{
    internal static class Program
    {
        public static int agenciaTrabajoId = 1; // ID de la agencia de trabajo, se puede cambiar según sea necesario
        public static int CDTrabajoId = 7; // ID del centro de distribución de trabajo, se puede cambiar según sea necesario
        public static string modalidadImposicion = "AGENCIA"; // Modalidad de imposición. Valores válidos: "AGENCIA", "CD", "DOMICILIO".
         
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
          
            Application.Run(new FormularioPrincipal());

            // Antes de salir, guardamos los datos en los alamcenes
            Almacenes.AgenciaAlmacen.Guardar();
            Almacenes.CentroDistribucionAlmacen.Guardar();
            Almacenes.ClienteAlmacen.Guardar();
            Almacenes.ConveniosTransporteAlmacen.Guardar();
            Almacenes.CuentaCorrienteClienteAlmacen.Guardar();
            Almacenes.DocumentoAlmacen.Guardar();
            Almacenes.EmpresaTransporteAlmacen.Guardar();
            Almacenes.FleteroAlmacen.Guardar();
            Almacenes.GuiaAlmacen.Guardar();
            Almacenes.HDRDistribucionAlmacen.Guardar();
            Almacenes.HDRRetiroAlmacen.Guardar();
            Almacenes.HDRTransporteAlmacen.Guardar();
            Almacenes.LocalidadAlmacen.Guardar();
            Almacenes.MovimientoEstadoGuiaAlmacen.Guardar();
            Almacenes.ProvinciaAlmacen.Guardar();
            Almacenes.ServicioTransporteAlmacen.Guardar();
            Almacenes.TarifarioAlmacen.Guardar();
            Almacenes.TarifaTransporteAlmacen.Guardar();
            
        }
    }
}   