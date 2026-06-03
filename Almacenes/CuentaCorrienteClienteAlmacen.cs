using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class CuentaCorrienteClienteAlmacen
    {
        public static List<CuentaCorrienteClienteEntidad> cuentaCorrienteClientes = new();

        static CuentaCorrienteClienteAlmacen()
        {
            if (File.Exists(@"cuentacorrientecliente.json"))
            {
                string json = File.ReadAllText(@"cuentacorrientecliente.json");
                cuentaCorrienteClientes = JsonSerializer.Deserialize<List<CuentaCorrienteClienteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(cuentaCorrienteClientes);
            File.WriteAllText(@"cuentacorrientecliente.json", json);
        }
    }
}
