using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class GuiaAlmacen
    {
        public static List<GuiaEntidad> guias = new();

        static GuiaAlmacen()
        {
            if (File.Exists(@"Datos\GuiaEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\GuiaEntidad.json");
                    guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            Converters = { new JsonStringEnumConverter() }
                        });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar GuiaEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(guias,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\GuiaEntidad.json", json);
        }
    }
}
