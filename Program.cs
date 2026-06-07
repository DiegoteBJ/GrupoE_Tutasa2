using GrupoE_Tutasa.GenerarHDR;
using GrupoE_Tutasa.GenerarHDRTransporte;

namespace GrupoE_Tutasa.FormularioPrincipal
{
    internal static class Program
    {
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
            Almacenes.LocalidadAlmacen.Guardar();
            Almacenes.ProvinciaAlmacen.Guardar();
            Almacenes.ServicioTransporteAlmacen.Guardar();
            Almacenes.TarifarioAlmacen.Guardar();
            Almacenes.TarifaTransporteAlmacen.Guardar();
            
        }
    }
}