namespace GrupoE_Tutasa.Imposicion
{
    internal class ImposicionModelo
    {
        // AL.1 - Clientes (Remitentes)
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

        // AL.22 - Provincias
        public List<Provincia> LProvincias
        {
            get
            {
                return new List<Provincia>
                {
                    new Provincia { ProvinciaId = 1, Nombre = "Buenos Aires" },
                    new Provincia { ProvinciaId = 2, Nombre = "Córdoba" },
                    new Provincia { ProvinciaId = 3, Nombre = "Mendoza" },
                    new Provincia { ProvinciaId = 4, Nombre = "Santa Fe" },
                    new Provincia { ProvinciaId = 5, Nombre = "Neuquén" },
                };
            }
        }

        // AL.21 - Localidades
        public List<Localidad> LLocalidades
        {
            get
            {
                return new List<Localidad>
                {
                    new Localidad { LocalidadId = 1,  ProvinciaId = 1, Nombre = "Buenos Aires Capital", CodigoPostalPrincipal = "C1000" },
                    new Localidad { LocalidadId = 2,  ProvinciaId = 1, Nombre = "Mar del Plata",        CodigoPostalPrincipal = "B7600" },
                    new Localidad { LocalidadId = 3,  ProvinciaId = 1, Nombre = "La Plata",             CodigoPostalPrincipal = "B1900" },
                    new Localidad { LocalidadId = 4,  ProvinciaId = 1, Nombre = "Bahía Blanca",         CodigoPostalPrincipal = "B8000" },
                    new Localidad { LocalidadId = 5,  ProvinciaId = 2, Nombre = "Córdoba Capital",      CodigoPostalPrincipal = "X5000" },
                    new Localidad { LocalidadId = 6,  ProvinciaId = 2, Nombre = "Río Cuarto",           CodigoPostalPrincipal = "X5800" },
                    new Localidad { LocalidadId = 7,  ProvinciaId = 2, Nombre = "Villa María",          CodigoPostalPrincipal = "X5900" },
                    new Localidad { LocalidadId = 8,  ProvinciaId = 3, Nombre = "Mendoza Capital",      CodigoPostalPrincipal = "M5500" },
                    new Localidad { LocalidadId = 9,  ProvinciaId = 3, Nombre = "San Rafael",           CodigoPostalPrincipal = "M5600" },
                    new Localidad { LocalidadId = 10, ProvinciaId = 4, Nombre = "Rosario",              CodigoPostalPrincipal = "S2000" },
                    new Localidad { LocalidadId = 11, ProvinciaId = 4, Nombre = "Santa Fe Capital",     CodigoPostalPrincipal = "S3000" },
                    new Localidad { LocalidadId = 12, ProvinciaId = 5, Nombre = "Neuquén Capital",      CodigoPostalPrincipal = "Q8300" },
                    new Localidad { LocalidadId = 13, ProvinciaId = 5, Nombre = "Zapala",               CodigoPostalPrincipal = "Q8340" },
                };
            }
        }

        // AL.3 - Agencias
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

        // AL.18 - Centros de Distribución
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

        // AL.14 - Guías
        public List<Guia> LGuias = new List<Guia>();

        private int ultimoGuiaId = 100;

        public void RegistrarGuia(Guia guia, int cdActualId)
        {
            ultimoGuiaId++;
            guia.GuiaId = ultimoGuiaId;
            guia.FechaImposicion = DateTime.Now;

            // CDActualId se registra solo cuando la imposición es en CD
            if (guia.ModalidadImposicion == ModalidadImposicionEnum.CD)
            {
                guia.CDActualId = cdActualId;
            }
            else
            {
                guia.CDActualId = null;
            }

            LGuias.Add(guia);
        }

        public List<Localidad> ObtenerLocalidadesPorProvincia(int provinciaId)
        {
            List<Localidad> resultado = new List<Localidad>();
            foreach (var localidad in LLocalidades)
            {
                if (localidad.ProvinciaId == provinciaId)
                {
                    resultado.Add(localidad);
                }
            }
            return resultado;
        }

        public List<Agencia> ObtenerAgenciasPorLocalidad(int localidadId)
        {
            List<Agencia> resultado = new List<Agencia>();
            foreach (var agencia in LAgencias)
            {
                if (agencia.Domicilio != null && agencia.Domicilio.LocalidadId == localidadId)
                {
                    resultado.Add(agencia);
                }
            }
            return resultado;
        }

        public List<CentroDistribucion> ObtenerCDsPorLocalidad(int localidadId)
        {
            List<CentroDistribucion> resultado = new List<CentroDistribucion>();
            foreach (var cd in LCentrosDistribucion)
            {
                if (cd.Domicilio != null && cd.Domicilio.LocalidadId == localidadId)
                {
                    resultado.Add(cd);
                }
            }
            return resultado;
        }

        public bool ValidarCuit(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit)) return false;

            // Extraer solo dígitos
            string soloDigitos = "";
            foreach (char c in cuit)
            {
                if (char.IsDigit(c))
                    soloDigitos = soloDigitos + c;
            }
            cuit = soloDigitos;

            if (cuit.Length != 11) return false;

            // Validar prefijo
            int prefijo = int.Parse(cuit.Substring(0, 2));
            if (prefijo != 20 && prefijo != 23 && prefijo != 24 &&
                prefijo != 27 && prefijo != 30 && prefijo != 33 && prefijo != 34)
            {
                return false;
            }

            // Calcular dígito verificador
            int[] coef = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma = suma + (cuit[i] - '0') * coef[i];
            }

            int resto = suma % 11;
            if (resto == 1) return false;

            int esperado = 0;
            if (resto != 0)
            {
                esperado = 11 - resto;
            }

            return (cuit[10] - '0') == esperado;
        }
    }
}
