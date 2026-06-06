using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class HDRTransporteAlmacen
    {
        public static List<HDRTransporteEntidad> hDRTransportes = new();

        static HDRTransporteAlmacen()
        {
            if (File.Exists(@"Datos\HDRTransporteEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\HDRTransporteEntidad.json");
                    hDRTransportes = JsonSerializer.Deserialize<List<HDRTransporteEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar HDRTransporteEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRTransportes,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\HDRTransporteEntidad.json", json);
        }
    }
}
