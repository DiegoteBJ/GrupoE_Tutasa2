using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class HDRRetiroAlmacen
    {
        public static List<HDRRetiroEntidad> hDRRetiros = new();

        static HDRRetiroAlmacen()
        {
            if (File.Exists(@"Datos\HDRRetiroEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\HDRRetiroEntidad.json");
                    hDRRetiros = JsonSerializer.Deserialize<List<HDRRetiroEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar HDRRetiroEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRRetiros,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\HDRRetiroEntidad.json", json);
        }
    }
}
