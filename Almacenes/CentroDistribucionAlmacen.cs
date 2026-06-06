using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class CentroDistribucionAlmacen
    {
        public static List<CentroDistribucionEntidad> centroDistribucions = new();

        static CentroDistribucionAlmacen()
        {
            if (File.Exists(@"Datos\CentroDistribucionEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\CentroDistribucionEntidad.json");
                    centroDistribucions = JsonSerializer.Deserialize<List<CentroDistribucionEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar CentroDistribucionEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(centroDistribucions,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\CentroDistribucionEntidad.json", json);
        }
    }
}
