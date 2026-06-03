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
            if (File.Exists(@"clientes.json"))
            {
                string json = File.ReadAllText(@"clientes.json");
                clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"clientes.json", json);
        }
    }
}
