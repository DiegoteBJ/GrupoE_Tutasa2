using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class FleteroAlmacen
    {
        public static List<FleteroEntidad> fleteros = new();

        static FleteroAlmacen()
        {
            if (File.Exists(@"Datos\FleteroEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\FleteroEntidad.json");
                    fleteros = JsonSerializer.Deserialize<List<FleteroEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar FleteroEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(fleteros,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\FleteroEntidad.json", json);
        }
    }
}
