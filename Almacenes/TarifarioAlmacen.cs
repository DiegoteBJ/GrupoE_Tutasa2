using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class TarifarioAlmacen
    {
        public static List<TarifarioEntidad> tarifarios = new();

        static TarifarioAlmacen()
        {
            if (File.Exists(@"Datos\TarifarioEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\TarifarioEntidad.json");
                    tarifarios = JsonSerializer.Deserialize<List<TarifarioEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar TarifarioEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(tarifarios,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\TarifarioEntidad.json", json);
        }
    }
}
