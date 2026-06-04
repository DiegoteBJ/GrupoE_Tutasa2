using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class HDRDistribucionAlmacen
    {
        public static List<HDRDistribucionEntidad> hDRDistribucions = new();

        static HDRDistribucionAlmacen()
        {
            if (File.Exists(@"Datos\HDRDistribucionEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\HDRDistribucionEntidad.json");
                    hDRDistribucions = JsonSerializer.Deserialize<List<HDRDistribucionEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar HDRDistribucionEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRDistribucions,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\HDRDistribucionEntidad.json", json);
        }
    }
}
