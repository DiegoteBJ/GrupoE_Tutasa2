using GrupoE_Tutasa.MonitoreoResultados;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.Imposicion
{
    internal class ImposicionModelo
    {
        // ─────────────────────────────────────────────
        // CLIENTES (Remitentes)
        // ─────────────────────────────────────────────
        public List<ClienteRemitente> LClientes
        {
            get
            {
                return new List<ClienteRemitente>
                {
                    new ClienteRemitente { ClienteId = 1, Nombre = "Juan Pérez",         Telefono = "11-11223344", Direccion = "Av. Corrientes 1111",  CUIT = 20123456789 },
                    new ClienteRemitente { ClienteId = 2, Nombre = "María García",       Telefono = "11-22334455", Direccion = "Av. Santa Fe 2222",    CUIT = 27202016494 },
                    new ClienteRemitente { ClienteId = 3, Nombre = "Carlos López",       Telefono = "351-3334444", Direccion = "Bv. San Juan 333",     CUIT = 20483900334 },
                    new ClienteRemitente { ClienteId = 4, Nombre = "Ana Martínez",       Telefono = "261-4445555", Direccion = "Av. San Martín 444",   CUIT = 27384592017 },
                    new ClienteRemitente { ClienteId = 5, Nombre = "Pedro Rodríguez",    Telefono = "299-5556666", Direccion = "Calle 9 de Julio 55",  CUIT = 20329642330 },
                    new ClienteRemitente { ClienteId = 6, Nombre = "Laura Fernández",    Telefono = "11-66778899", Direccion = "Rivadavia 6666",       CUIT = 30654364229 },
                    new ClienteRemitente { ClienteId = 7, Nombre = "Logística Omega SA", Telefono = "11-77889900", Direccion = "Av. de Mayo 777",      CUIT = 30765432109 },
                };
            }
        }

        // ─────────────────────────────────────────────
        // PROVINCIAS
        // ─────────────────────────────────────────────
        public List<Provincia> LProvincias
        {
            get
            {
                return new List<Provincia>
                {
                    new Provincia { ProvinciaId = 1, Nombre = "Buenos Aires" },
                    new Provincia { ProvinciaId = 2, Nombre = "Córdoba"      },
                    new Provincia { ProvinciaId = 3, Nombre = "Mendoza"      },
                    new Provincia { ProvinciaId = 4, Nombre = "Santa Fe"     },
                    new Provincia { ProvinciaId = 5, Nombre = "Neuquén"      },
                };
            }
        }

        // ─────────────────────────────────────────────
        // LOCALIDADES
        // ─────────────────────────────────────────────
        public List<Localidad> LLocalidades
        {
            get
            {
                return new List<Localidad>
                {
                    // Buenos Aires
                    new Localidad { LocalidadId = 1,  ProvinciaId = 1, Nombre = "Buenos Aires Capital" },
                    new Localidad { LocalidadId = 2,  ProvinciaId = 1, Nombre = "Mar del Plata"        },
                    new Localidad { LocalidadId = 3,  ProvinciaId = 1, Nombre = "La Plata"             },
                    new Localidad { LocalidadId = 4,  ProvinciaId = 1, Nombre = "Bahía Blanca"         },
                    // Córdoba
                    new Localidad { LocalidadId = 5,  ProvinciaId = 2, Nombre = "Córdoba Capital" },
                    new Localidad { LocalidadId = 6,  ProvinciaId = 2, Nombre = "Río Cuarto"      },
                    new Localidad { LocalidadId = 7,  ProvinciaId = 2, Nombre = "Villa María"     },
                    // Mendoza
                    new Localidad { LocalidadId = 8,  ProvinciaId = 3, Nombre = "Mendoza Capital" },
                    new Localidad { LocalidadId = 9,  ProvinciaId = 3, Nombre = "San Rafael"      },
                    // Santa Fe
                    new Localidad { LocalidadId = 10, ProvinciaId = 4, Nombre = "Rosario"          },
                    new Localidad { LocalidadId = 11, ProvinciaId = 4, Nombre = "Santa Fe Capital" },
                    // Neuquén
                    new Localidad { LocalidadId = 12, ProvinciaId = 5, Nombre = "Neuquén Capital" },
                    new Localidad { LocalidadId = 13, ProvinciaId = 5, Nombre = "Zapala"          },
                };
            }
        }

        // ─────────────────────────────────────────────
        // AGENCIAS
        // ─────────────────────────────────────────────
        public List<Agencia> LAgencias
        {
            get
            {
                return new List<Agencia>
                {
                    new Agencia { AgenciaId = 1, LocalidadId = 1,  Nombre = "Agencia BA Centro",     Direccion = "Florida 100",        CodigoPostal = "C1005" },
                    new Agencia { AgenciaId = 2, LocalidadId = 2,  Nombre = "Agencia Mar del Plata", Direccion = "San Martín 300",     CodigoPostal = "B7600" },
                    new Agencia { AgenciaId = 3, LocalidadId = 5,  Nombre = "Agencia Córdoba Norte", Direccion = "Colón 500",          CodigoPostal = "X5000" },
                    new Agencia { AgenciaId = 4, LocalidadId = 8,  Nombre = "Agencia Mendoza",       Direccion = "Av. San Martín 200", CodigoPostal = "M5500" },
                    new Agencia { AgenciaId = 5, LocalidadId = 10, Nombre = "Agencia Rosario Sur",   Direccion = "Mitre 750",          CodigoPostal = "S2000" },
                    new Agencia { AgenciaId = 6, LocalidadId = 12, Nombre = "Agencia Neuquén",       Direccion = "Av. Argentina 150",  CodigoPostal = "Q8300" },
                };
            }
        }

        // ─────────────────────────────────────────────
        // CENTROS DE DISTRIBUCIÓN
        // ─────────────────────────────────────────────
        public List<CentroDistribucion> LCentrosDistribucion
        {
            get
            {
                return new List<CentroDistribucion>
                {
                    new CentroDistribucion { CDId = 1, LocalidadId = 1,  Nombre = "CD-0001 Buenos Aires Centro", Direccion = "Av. Belgrano 1500",  CodigoPostal = "C1093" },
                    new CentroDistribucion { CDId = 2, LocalidadId = 3,  Nombre = "CD-0002 La Plata",            Direccion = "Diagonal 74 Nº400",  CodigoPostal = "B1900" },
                    new CentroDistribucion { CDId = 3, LocalidadId = 5,  Nombre = "CD-0003 Córdoba",             Direccion = "Av. Maipú 2200",     CodigoPostal = "X5016" },
                    new CentroDistribucion { CDId = 4, LocalidadId = 10, Nombre = "CD-0004 Rosario",             Direccion = "Av. Pellegrini 900", CodigoPostal = "S2008" },
                };
            }
        }

        // ─────────────────────────────────────────────
        // TARIFAS
        // ─────────────────────────────────────────────
        public List<Tarifa> LTarifas
        {
            get
            {
                return new List<Tarifa>
                {
                    new Tarifa { TarifaId = 1, Tipo = "S",  Descripcion = "Hasta 2,5 kg", PrecioBase = 3500,  PrecioKmAdicional = 5  },
                    new Tarifa { TarifaId = 2, Tipo = "M",  Descripcion = "Hasta 5 kg",   PrecioBase = 6000,  PrecioKmAdicional = 8  },
                    new Tarifa { TarifaId = 3, Tipo = "L",  Descripcion = "Hasta 10 kg",  PrecioBase = 10000, PrecioKmAdicional = 12 },
                    new Tarifa { TarifaId = 4, Tipo = "XL", Descripcion = "Hasta 20 kg",  PrecioBase = 16000, PrecioKmAdicional = 18 },
                };
            }
        }

        // ─────────────────────────────────────────────
        // GUÍAS (se llenan al confirmar la imposición)
        // ─────────────────────────────────────────────
        public List<Guia> LGuias { get; private set; } = new List<Guia>();

        private static int _ultimoNumeroGuia = 100;

        public string GenerarNumeroGuia()
        {
            _ultimoNumeroGuia++;
            return $"G{_ultimoNumeroGuia:D8}";
        }

        public void RegistrarGuia(Guia guia)
        {
            guia.NumeroGuia = GenerarNumeroGuia();
            guia.FechaImposicion = DateTime.Now;
            LGuias.Add(guia);
        }

        // ─────────────────────────────────────────────
        // MÉTODOS AUXILIARES
        // ─────────────────────────────────────────────

        public List<Localidad> ObtenerLocalidadesPorProvincia(int provinciaId)
        {
            return LLocalidades.Where(l => l.ProvinciaId == provinciaId).ToList();
        }

        public List<Agencia> ObtenerAgenciasPorLocalidad(int localidadId)
        {
            return LAgencias.Where(a => a.LocalidadId == localidadId).ToList();
        }

        public List<CentroDistribucion> ObtenerCDsPorLocalidad(int localidadId)
        {
            return LCentrosDistribucion.Where(cd => cd.LocalidadId == localidadId).ToList();
        }

        public decimal CalcularImporteEstimado(int cantS, int cantM, int cantL, int cantXL)
        {
            var tarifas = LTarifas;
            decimal total = 0;
            total += cantS * tarifas.First(t => t.Tipo == "S").PrecioBase;
            total += cantM * tarifas.First(t => t.Tipo == "M").PrecioBase;
            total += cantL * tarifas.First(t => t.Tipo == "L").PrecioBase;
            total += cantXL * tarifas.First(t => t.Tipo == "XL").PrecioBase;
            return total;
        }

        public static bool ValidarCuit(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit)) return false;

            cuit = new string(cuit.Where(char.IsDigit).ToArray());

            if (cuit.Length != 11) return false;

            int prefijo = int.Parse(cuit[..2]);
            if (!new[] { 20, 23, 24, 27, 30, 33, 34 }.Contains(prefijo)) return false;

            int[] coef = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
                suma += (cuit[i] - '0') * coef[i];

            int resto = suma % 11;
            if (resto == 1) return false;

            int esperado = resto == 0 ? 0 : 11 - resto;
            return (cuit[10] - '0') == esperado;
        }
    }
}


