using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class ClienteAlmacen
    {
        public static List<ClienteEntidad> clientes = new();

        static ClienteAlmacen()
        {
            if (File.Exists(@"Datos\ClienteEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\ClienteEntidad.json");
                    clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar ClienteEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(clientes,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\ClienteEntidad.json", json);
        }
    }
}
