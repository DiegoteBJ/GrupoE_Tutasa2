using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class MovimientoEstadoGuiaAlmacen
    {
        public static List<MovimientoEstadoGuiaEntidad> movimientoEstadoGuias = new();

        static MovimientoEstadoGuiaAlmacen()
        {
            if (File.Exists(@"Datos\MovimientoEstadoGuiaEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\MovimientoEstadoGuiaEntidad.json");
                    movimientoEstadoGuias = JsonSerializer.Deserialize<List<MovimientoEstadoGuiaEntidad>>(json,
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true,
                            Converters = { new JsonStringEnumConverter() }
                        });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar MovimientoEstadoGuiaEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(movimientoEstadoGuias,
                new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Converters = { new JsonStringEnumConverter() }
                });
            File.WriteAllText(@"Datos\MovimientoEstadoGuiaEntidad.json", json);
        }
    }
}
