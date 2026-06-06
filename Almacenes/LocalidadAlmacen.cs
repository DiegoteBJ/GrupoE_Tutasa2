using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class LocalidadAlmacen
    {
        public static List<LocalidadEntidad> localidads = new();

        static LocalidadAlmacen()
        {
            if (File.Exists(@"Datos\LocalidadEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\LocalidadEntidad.json");
                    localidads = JsonSerializer.Deserialize<List<LocalidadEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar LocalidadEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(localidads,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\LocalidadEntidad.json", json);
        }
    }
}
