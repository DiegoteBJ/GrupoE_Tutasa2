using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class AgenciaAlmacen
    {
        public static List<AgenciaEntidad> agencias = new();

        static AgenciaAlmacen()
        {
            if (File.Exists(@"Datos\AgenciaEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\AgenciaEntidad.json");
                    agencias = JsonSerializer.Deserialize<List<AgenciaEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar AgenciaEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(agencias,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\AgenciaEntidad.json", json);
        }
    }
}
