using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class ServicioTransporteAlmacen
    {
        public static List<ServicioTransporteEntidad> servicioTransportes = new();

        static ServicioTransporteAlmacen()
        {
            if (File.Exists(@"Datos\ServicioTransporteEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\ServicioTransporteEntidad.json");
                    servicioTransportes = JsonSerializer.Deserialize<List<ServicioTransporteEntidad>>(json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            Converters = { new JsonStringEnumConverter() }
                        });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar ServicioTransporteEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(servicioTransportes,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\ServicioTransporteEntidad.json", json);
        }
    }
}
