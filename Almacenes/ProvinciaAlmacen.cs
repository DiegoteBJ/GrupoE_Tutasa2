using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class ProvinciaAlmacen
    {
        public static List<ProvinciaEntidad> provincias = new();

        static ProvinciaAlmacen()
        {
            if (File.Exists(@"Datos\ProvinciaEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\ProvinciaEntidad.json");
                    provincias = JsonSerializer.Deserialize<List<ProvinciaEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar ProvinciaEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(provincias,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\ProvinciaEntidad.json", json);
        }
    }
}
