using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class ConveniosTransporteAlmacen
    {
        public static List<ConveniosTransporteEntidad> conveniosTransportes = new();

        static ConveniosTransporteAlmacen()
        {
            if (File.Exists(@"Datos\ConveniosTransporteEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\ConveniosTransporteEntidad.json");
                    conveniosTransportes = JsonSerializer.Deserialize<List<ConveniosTransporteEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar ConveniosTransporteEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(conveniosTransportes,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\ConveniosTransporteEntidad.json", json);
        }
    }
}
