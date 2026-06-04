using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class EmpresaTransporteAlmacen
    {
        public static List<EmpresaTransporteEntidad> empresaTransportes = new();

        static EmpresaTransporteAlmacen()
        {
            if (File.Exists(@"Datos\EmpresaTransporteEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\EmpresaTransporteEntidad.json");
                    empresaTransportes = JsonSerializer.Deserialize<List<EmpresaTransporteEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar EmpresaTransporteEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(empresaTransportes,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\EmpresaTransporteEntidad.json", json);
        }
    }
}
