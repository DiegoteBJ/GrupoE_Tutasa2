using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class ClienteAlmacen
    {
        public static List<ClienteEntidad> clientes = new();

        static ClienteAlmacen()
        {
            if (File.Exists(@"\Datos\ClienteEntidad.json"))
            {
                string json = File.ReadAllText(@"\Datos\ClienteEntidad.json");
                clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"\Datos\ClienteEntidad.json", json);
        }
    }
}
