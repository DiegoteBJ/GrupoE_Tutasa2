using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace GrupoE_Tutasa.Almacenes
{
    internal static class CuentaCorrienteClienteAlmacen
    {
        public static List<CuentaCorrienteClienteEntidad> cuentaCorrienteClientes = new();

        static CuentaCorrienteClienteAlmacen()
        {
            if (File.Exists(@"Datos\CuentaCorrienteClienteEntidad.json"))
            {
                try
                {
                    string json = File.ReadAllText(@"Datos\CuentaCorrienteClienteEntidad.json");
                    cuentaCorrienteClientes = JsonSerializer.Deserialize<List<CuentaCorrienteClienteEntidad>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show($"Error al cargar CuentaCorrienteClienteEntidad.json: {ex.Message}");
                }
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(cuentaCorrienteClientes,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\CuentaCorrienteClienteEntidad.json", json);
        }
    }
}
