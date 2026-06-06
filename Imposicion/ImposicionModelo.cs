namespace GrupoE_Tutasa.Imposicion
{
    internal class ImposicionModelo
    {
        // ─────────────────────────────────────────────
        // AL.1 - CLIENTES (Remitentes)
        // ─────────────────────────────────────────────
        public List<ClienteRemitente> LClientes
        {
            get
            {
                return new List<ClienteRemitente>
                {
                    new ClienteRemitente
                    {
                        ClienteId = 1, RazonSocial = "Juan Pérez", Nombre = "Juan", Apellido = "Pérez",
                        CUIT = "20123456789", Telefono = "11-11223344",
                        Domicilio = new Domicilio { Calle = "Av. Corrientes", Numero = "1111", CodigoPostal = "C1043", LocalidadId = 1 }
                    },
                    new ClienteRemitente
                    {
                        ClienteId = 2, RazonSocial = "María García", Nombre = "María", Apellido = "García",
                        CUIT = "27202016494", Telefono = "11-22334455",
                        Domicilio = new Domicilio { Calle = "Av. Santa Fe", Numero = "2222", CodigoPostal = "C1123", LocalidadId = 1 }
                    },
                    new ClienteRemitente
                    {
                        ClienteId = 3, RazonSocial = "Carlos López", Nombre = "Carlos", Apellido = "López",
                        CUIT = "20483900334", Telefono = "351-3334444",
                        Domicilio = new Domicilio { Calle = "Bv. San Juan", Numero = "333", CodigoPostal = "X5000", LocalidadId = 5 }
                    },
                    new ClienteRemitente
                    {
                        ClienteId = 4, RazonSocial = "Ana Martínez", Nombre = "Ana", Apellido = "Martínez",
                        CUIT = "27384592017", Telefono = "261-4445555",
                        Domicilio = new Domicilio { Calle = "Av. San Martín", Numero = "444", CodigoPostal = "M5500", LocalidadId = 8 }
                    },
                    new ClienteRemitente
                    {
                        ClienteId = 5, RazonSocial = "Pedro Rodríguez", Nombre = "Pedro", Apellido = "Rodríguez",
                        CUIT = "20329642330", Telefono = "299-5556666",
                        Domicilio = new Domicilio { Calle = "Calle 9 de Julio", Numero = "55", CodigoPostal = "Q8300", LocalidadId = 12 }
                    },
                    new ClienteRemitente
                    {
                        ClienteId = 6, RazonSocial = "Laura Fernández", Nombre = "Laura", Apellido = "Fernández",
                        CUIT = "30654364229", Telefono = "11-66778899",
                        Domicilio = new Domicilio { Calle = "Rivadavia", Numero = "6666", CodigoPostal = "C1002", LocalidadId = 1 }
                    },
                    new ClienteRemitente
                    {
                        ClienteId = 7, RazonSocial = "Logística Omega SA", Nombre = string.Empty, Apellido = string.Empty,
                        CUIT = "30765432109", Telefono = "11-77889900",
                        Domicilio = new Domicilio { Calle = "Av. de Mayo", Numero = "777", CodigoPostal = "C1084", LocalidadId = 1 }
                    },
                };
            }
        }

        // ─────────────────────────────────────────────
        // AL.22 - PROVINCIAS
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
        // AL.21 - LOCALIDADES
        // ─────────────────────────────────────────────
        public List<Localidad> LLocalidades
        {
            get
            {
                return new List<Localidad>
                {
                    // Buenos Aires
                    new Localidad { LocalidadId = 1,  ProvinciaId = 1, Nombre = "Buenos Aires Capital", CodigoPostalPrincipal = "C1000" },
                    new Localidad { LocalidadId = 2,  ProvinciaId = 1, Nombre = "Mar del Plata",        CodigoPostalPrincipal = "B7600" },
                    new Localidad { LocalidadId = 3,  ProvinciaId = 1, Nombre = "La Plata",             CodigoPostalPrincipal = "B1900" },
                    new Localidad { LocalidadId = 4,  ProvinciaId = 1, Nombre = "Bahía Blanca",         CodigoPostalPrincipal = "B8000" },
                    // Córdoba
                    new Localidad { LocalidadId = 5,  ProvinciaId = 2, Nombre = "Córdoba Capital",      CodigoPostalPrincipal = "X5000" },
                    new Localidad { LocalidadId = 6,  ProvinciaId = 2, Nombre = "Río Cuarto",           CodigoPostalPrincipal = "X5800" },
                    new Localidad { LocalidadId = 7,  ProvinciaId = 2, Nombre = "Villa María",          CodigoPostalPrincipal = "X5900" },
                    // Mendoza
                    new Localidad { LocalidadId = 8,  ProvinciaId = 3, Nombre = "Mendoza Capital",      CodigoPostalPrincipal = "M5500" },
                    new Localidad { LocalidadId = 9,  ProvinciaId = 3, Nombre = "San Rafael",           CodigoPostalPrincipal = "M5600" },
                    // Santa Fe
                    new Localidad { LocalidadId = 10, ProvinciaId = 4, Nombre = "Rosario",              CodigoPostalPrincipal = "S2000" },
                    new Localidad { LocalidadId = 11, ProvinciaId = 4, Nombre = "Santa Fe Capital",     CodigoPostalPrincipal = "S3000" },
                    // Neuquén
                    new Localidad { LocalidadId = 12, ProvinciaId = 5, Nombre = "Neuquén Capital",      CodigoPostalPrincipal = "Q8300" },
                    new Localidad { LocalidadId = 13, ProvinciaId = 5, Nombre = "Zapala",               CodigoPostalPrincipal = "Q8340" },
                };
            }
        }

        // ─────────────────────────────────────────────
        // AL.3 - AGENCIAS
        // ─────────────────────────────────────────────
        public List<Agencia> LAgencias
        {
            get
            {
                return new List<Agencia>
                {
                    new Agencia
                    {
                        AgenciaId = 1, RazonSocial = "Agencia BA Centro", CDAsignadoId = 1,
                        Domicilio = new Domicilio { Calle = "Florida", Numero = "100", CodigoPostal = "C1005", LocalidadId = 1 },
                        MontoFijoComisionRecepcion = 150, MontoFijoComisionEntrega = 150,
                        CodigosPostalesCobertura = new List<string> { "C1005", "C1006" }
                    },
                    new Agencia
                    {
                        AgenciaId = 2, RazonSocial = "Agencia Mar del Plata", CDAsignadoId = 1,
                        Domicilio = new Domicilio { Calle = "San Martín", Numero = "300", CodigoPostal = "B7600", LocalidadId = 2 },
                        MontoFijoComisionRecepcion = 150, MontoFijoComisionEntrega = 150,
                        CodigosPostalesCobertura = new List<string> { "B7600" }
                    },
                    new Agencia
                    {
                        AgenciaId = 3, RazonSocial = "Agencia Córdoba Norte", CDAsignadoId = 3,
                        Domicilio = new Domicilio { Calle = "Colón", Numero = "500", CodigoPostal = "X5000", LocalidadId = 5 },
                        MontoFijoComisionRecepcion = 150, MontoFijoComisionEntrega = 150,
                        CodigosPostalesCobertura = new List<string> { "X5000", "X5016" }
                    },
                    new Agencia
                    {
                        AgenciaId = 4, RazonSocial = "Agencia Mendoza", CDAsignadoId = 1,
                        Domicilio = new Domicilio { Calle = "Av. San Martín", Numero = "200", CodigoPostal = "M5500", LocalidadId = 8 },
                        MontoFijoComisionRecepcion = 150, MontoFijoComisionEntrega = 150,
                        CodigosPostalesCobertura = new List<string> { "M5500" }
                    },
                    new Agencia
                    {
                        AgenciaId = 5, RazonSocial = "Agencia Rosario Sur", CDAsignadoId = 4,
                        Domicilio = new Domicilio { Calle = "Mitre", Numero = "750", CodigoPostal = "S2000", LocalidadId = 10 },
                        MontoFijoComisionRecepcion = 150, MontoFijoComisionEntrega = 150,
                        CodigosPostalesCobertura = new List<string> { "S2000", "S2008" }
                    },
                    new Agencia
                    {
                        AgenciaId = 6, RazonSocial = "Agencia Neuquén", CDAsignadoId = 1,
                        Domicilio = new Domicilio { Calle = "Av. Argentina", Numero = "150", CodigoPostal = "Q8300", LocalidadId = 12 },
                        MontoFijoComisionRecepcion = 150, MontoFijoComisionEntrega = 150,
                        CodigosPostalesCobertura = new List<string> { "Q8300" }
                    },
                };
            }
        }

        // ─────────────────────────────────────────────
        // AL.18 - CENTROS DE DISTRIBUCIÓN
        // ─────────────────────────────────────────────
        public List<CentroDistribucion> LCentrosDistribucion
        {
            get
            {
                return new List<CentroDistribucion>
                {
                    new CentroDistribucion
                    {
                        CDId = 1, Nombre = "CD-0001 Buenos Aires Centro",
                        Domicilio = new Domicilio { Calle = "Av. Belgrano", Numero = "1500", CodigoPostal = "C1093", LocalidadId = 1 }
                    },
                    new CentroDistribucion
                    {
                        CDId = 2, Nombre = "CD-0002 La Plata",
                        Domicilio = new Domicilio { Calle = "Diagonal 74", Numero = "400", CodigoPostal = "B1900", LocalidadId = 3 }
                    },
                    new CentroDistribucion
                    {
                        CDId = 3, Nombre = "CD-0003 Córdoba",
                        Domicilio = new Domicilio { Calle = "Av. Maipú", Numero = "2200", CodigoPostal = "X5016", LocalidadId = 5 }
                    },
                    new CentroDistribucion
                    {
                        CDId = 4, Nombre = "CD-0004 Rosario",
                        Domicilio = new Domicilio { Calle = "Av. Pellegrini", Numero = "900", CodigoPostal = "S2008", LocalidadId = 10 }
                    },
                };
            }
        }

        // ─────────────────────────────────────────────
        // AL.2.1 - TARIFARIO GENERAL
        // ─────────────────────────────────────────────
        public List<Tarifario> LTarifarios
        {
            get
            {
                return new List<Tarifario>
                {
                    new Tarifario
                    {
                        TarifarioId = 1,
                        TarifaRetiroDomicilio       = 800m,
                        TarifaEntregaAgencia        = 300m,
                        TarifaDistribucionDomicilio = 600m
                    }
                };
            }
        }

        // ─────────────────────────────────────────────
        // AL.2.2 - TARIFAS DE TRANSPORTE
        // ─────────────────────────────────────────────
        public List<TarifaTransporte> LTarifasTransporte
        {
            get
            {
                return new List<TarifaTransporte>
                {
                    new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 3, CoeficienteS = 3500m,  CoeficienteM = 6000m,  CoeficienteL = 10000m, CoeficienteXL = 16000m },
                    new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 4, CoeficienteS = 3200m,  CoeficienteM = 5500m,  CoeficienteL = 9000m,  CoeficienteXL = 14000m },
                    new TarifaTransporte { CDOrigenId = 3, CDDestinoId = 1, CoeficienteS = 3500m,  CoeficienteM = 6000m,  CoeficienteL = 10000m, CoeficienteXL = 16000m },
                    new TarifaTransporte { CDOrigenId = 4, CDDestinoId = 1, CoeficienteS = 3200m,  CoeficienteM = 5500m,  CoeficienteL = 9000m,  CoeficienteXL = 14000m },
                    // Mismo CD origen y destino → sin tarifa de transporte
                    new TarifaTransporte { CDOrigenId = 1, CDDestinoId = 1, CoeficienteS = 0m, CoeficienteM = 0m, CoeficienteL = 0m, CoeficienteXL = 0m },
                };
            }
        }

        // ─────────────────────────────────────────────
        // AL.14 - GUÍAS
        // ─────────────────────────────────────────────
        public List<Guia> LGuias { get; private set; } = new List<Guia>();

        private static int _ultimoGuiaId = 100;

        /// <summary>
        /// Registra una guía aplicando la regla de negocio de CDActualId:
        /// solo se asigna cuando la modalidad de imposición es en CD.
        /// </summary>
        /// <param name="guia">Guía a registrar (sin GuiaId ni FechaImposicion).</param>
        /// <param name="cdActualId">ID del CD donde se está operando.</param>
        public void RegistrarGuia(Guia guia, int cdActualId)
        {
            guia.GuiaId          = ++_ultimoGuiaId;
            guia.FechaImposicion = DateTime.Now;

            // Regla de negocio: CDActualId se registra SOLO en imposición de CD.
            // Para imposición telefónica (DOMICILIO) y en agencia (AGENCIA) queda null.
            guia.CDActualId = guia.ModalidadImposicion == ModalidadImposicionEnum.CD
                ? cdActualId
                : (int?)null;

            LGuias.Add(guia);
        }

        // ─────────────────────────────────────────────
        // MÉTODOS AUXILIARES
        // ─────────────────────────────────────────────

        public List<Localidad> ObtenerLocalidadesPorProvincia(int provinciaId)
            => LLocalidades.Where(l => l.ProvinciaId == provinciaId).ToList();

        public List<Agencia> ObtenerAgenciasPorLocalidad(int localidadId)
            => LAgencias.Where(a => a.Domicilio?.LocalidadId == localidadId).ToList();

        public List<CentroDistribucion> ObtenerCDsPorLocalidad(int localidadId)
            => LCentrosDistribucion.Where(cd => cd.Domicilio?.LocalidadId == localidadId).ToList();

        /// <summary>
        /// Calcula el importe estimado usando los coeficientes de la tarifa de transporte
        /// entre el CD de origen y el CD de destino, sumado a extras si corresponde.
        /// Si no existe ruta, usa precio base por defecto.
        /// </summary>
        public decimal CalcularImporteEstimado(int cantS, int cantM, int cantL, int cantXL,
                                               int cdOrigenId, int cdDestinoId,
                                               ModalidadEntregaEnum modalidadEntrega)
        {
            var tarifa = LTarifasTransporte
                .FirstOrDefault(t => t.CDOrigenId == cdOrigenId && t.CDDestinoId == cdDestinoId)
                ?? LTarifasTransporte.First(); // fallback al primero si no hay ruta exacta

            var tarifario = LTarifarios.First();

            decimal total = 0;
            total += cantS  * tarifa.CoeficienteS;
            total += cantM  * tarifa.CoeficienteM;
            total += cantL  * tarifa.CoeficienteL;
            total += cantXL * tarifa.CoeficienteXL;

            int totalBultos = cantS + cantM + cantL + cantXL;

            // Extra por modalidad de entrega
            if (modalidadEntrega == ModalidadEntregaEnum.DOMICILIO)
                total += tarifario.TarifaDistribucionDomicilio * totalBultos;
            else if (modalidadEntrega == ModalidadEntregaEnum.AGENCIA)
                total += tarifario.TarifaEntregaAgencia * totalBultos;

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
            int suma   = 0;
            for (int i = 0; i < 10; i++)
                suma += (cuit[i] - '0') * coef[i];

            int resto    = suma % 11;
            if (resto == 1) return false;

            int esperado = resto == 0 ? 0 : 11 - resto;
            return (cuit[10] - '0') == esperado;
        }
    }
}
