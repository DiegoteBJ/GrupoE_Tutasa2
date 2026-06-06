using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class TarifaTransporteAlmacen
    {
        public static List<TarifaTransporteEntidad> tarifaTransportes = new();

        static TarifaTransporteAlmacen()
        {
            if (File.Exists(@"Datos\TarifaTransporteEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\TarifaTransporteEntidad.json");
                    tarifaTransportes = JsonSerializer.Deserialize<List<TarifaTransporteEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar TarifaTransporteEntidad.json: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo TarifaTransporteEntidad.json.");
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(tarifaTransportes,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\TarifaTransporteEntidad.json", json);
        }
    }
}
