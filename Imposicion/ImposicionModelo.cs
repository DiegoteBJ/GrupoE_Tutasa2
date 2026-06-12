using GrupoE_Tutasa.Almacenes;
using GrupoE_Tutasa.FormularioPrincipal;
using System.Collections.Generic;
using System.Linq;

namespace GrupoE_Tutasa.Imposicion
{
    internal class ImposicionModelo
    {
        public static string modalidadImposicion = Program.modalidadImposicion; 
        public static int cdTrabajoId = Program.CDTrabajoId;
        public static int agenciaTrabajoId = Program.agenciaTrabajoId;
        public ClienteRemitente clienteActual = null;

        // Modalidad de imposición configurada (Program.modalidadImposicion) traducida al enum,
        // para que el formulario no necesite conocer los textos.
        public ModalidadImposicionEnum ModalidadImposicionActual
        {
            get
            {
                string m = (modalidadImposicion ?? string.Empty).Trim().ToUpper();
                if (m == "DOMICILIO") return ModalidadImposicionEnum.DOMICILIO;
                if (m == "AGENCIA")   return ModalidadImposicionEnum.AGENCIA;
                return ModalidadImposicionEnum.CD;
            }
        }


        public List<ClienteRemitente> LClientes =>
            ClienteAlmacen.clientes.Select(c => new ClienteRemitente
            {
                ClienteId    = c.ClienteId,
                RazonSocial  = c.RazonSocial,
                Nombre       = c.Nombre,
                Apellido     = c.Apellido,
                CUIT         = c.Cuit,
                Telefono     = c.Telefono,
                Domicilio    = c.Domicilio != null ? new Domicilio
                {
                    Calle        = c.Domicilio.Calle,
                    Numero       = c.Domicilio.Numero,
                    CodigoPostal = c.Domicilio.CodigoPostal,
                    LocalidadId  = c.Domicilio.LocalidadId
                } : null
            }).ToList();

        // AL.22 - Provincias
        public List<Provincia> LProvincias =>
            ProvinciaAlmacen.provincias.Select(p => new Provincia
            {
                ProvinciaId = p.ProvinciaId,
                Nombre      = p.Nombre
            }).ToList();

        // AL.21 - Localidades
        public List<Localidad> LLocalidades =>
            LocalidadAlmacen.localidads.Select(l => new Localidad
            {
                LocalidadId           = l.LocalidadId,
                ProvinciaId           = l.ProvinciaId,
                Nombre                = l.Nombre,
                CodigoPostalPrincipal = l.CodigoPostalPrincipal
            }).ToList();

        // AL.3 - Agencias
        public List<Agencia> LAgencias =>
            AgenciaAlmacen.agencias.Select(a => new Agencia
            {
                AgenciaId                  = a.AgenciaId,
                RazonSocial                = a.RazonSocial,
                Nombre                     = a.Nombre,
                Apellido                   = a.Apellido,
                CUIT                       = a.Cuit,
                Telefono                   = string.Empty,
                CDAsignadoId               = a.CDAsignadoId,
                MontoFijoComisionRecepcion = a.MontoFijoComisionRecepcion,
                MontoFijoComisionEntrega   = a.MontoFijoComisionEntrega,
                CodigosPostalesCobertura   = a.CodigosPostalesCobertura ?? new List<string>(),
                Domicilio = a.Domicilio != null ? new Domicilio
                {
                    Calle        = a.Domicilio.Calle,
                    Numero       = a.Domicilio.Numero,
                    CodigoPostal = a.Domicilio.CodigoPostal,
                    LocalidadId  = a.Domicilio.LocalidadId
                } : null
            }).ToList();

        // AL.18 - Centros de Distribución
        public List<CentroDistribucion> LCentrosDistribucion =>
            CentroDistribucionAlmacen.centroDistribucions.Select(cd => new CentroDistribucion
            {
                CDId      = cd.CdId,
                Nombre    = cd.Nombre,
                Domicilio = cd.Domicilio != null ? new Domicilio
                {
                    Calle        = cd.Domicilio.Calle,
                    Numero       = cd.Domicilio.Numero,
                    CodigoPostal = cd.Domicilio.CodigoPostal,
                    LocalidadId  = cd.Domicilio.LocalidadId
                } : null
            }).ToList();

        // AL.14 - Guías
        public List<Guia> LGuias =>
            GuiaAlmacen.guias.Select(g => new Guia
            {
                GuiaId                = g.GuiaId,
                ClienteId             = g.ClienteId,
                AgenciaOrigenId       = g.AgenciaOrigenId,
                CDOrigenId            = g.CDOrigenId,
                CDDestinoId           = g.CDDestinoId,
                CDActualId            = g.CDActualId == 0 ? (int?)null : g.CDActualId,
                ModalidadImposicion   = (ModalidadImposicionEnum)g.ModalidadImposicion,
                DomicilioRetiro       = g.DomicilioRetiro != null ? new Domicilio
                {
                    Calle        = g.DomicilioRetiro.Calle,
                    Numero       = g.DomicilioRetiro.Numero,
                    CodigoPostal = g.DomicilioRetiro.CodigoPostal,
                    LocalidadId  = g.DomicilioRetiro.LocalidadId
                } : null,
                ModalidadEntrega      = (ModalidadEntregaEnum)g.ModalidadEntrega,
                AgenciaDestinoId      = g.AgenciaDestinoId,
                DomicilioEntrega      = g.DomicilioEntrega != null ? new Domicilio
                {
                    Calle        = g.DomicilioEntrega.Calle,
                    Numero       = g.DomicilioEntrega.Numero,
                    CodigoPostal = g.DomicilioEntrega.CodigoPostal,
                    LocalidadId  = g.DomicilioEntrega.LocalidadId
                } : null,
                NombreDestinatario    = g.NombreDestinatario,
                ApellidoDestinatario  = g.ApellidoDestinatario,
                DNIDestinatario       = g.DniDestinatario,
                TipoCaja              = (TipoCajaEnum)g.TipoCaja,
                IntentosDeEntrega     = g.IntentosDeEntrega,
                Estado                = (EstadoGuiaEnum)g.Estado,
                TarifarioId           = g.TarifarioId,
                ObservacionesAdmision = g.ObservacionesAdmision
            }).ToList();

        // Asigna los datos de ORIGEN de la guía según la modalidad de imposición.
        // El formulario sólo aporta el domicilio de retiro; las reglas viven acá.
        public void AsignarDatosOrigen(Guia guia, Domicilio domicilioRetiro)
        {
            guia.ModalidadImposicion = ModalidadImposicionActual;

            if (ModalidadImposicionActual == ModalidadImposicionEnum.DOMICILIO)
            {
                // Regla 1: en imposición a domicilio no hay agencia de origen.
                guia.AgenciaOrigenId = null;

                // Regla 2: el CD de origen se resuelve por el CP del domicilio de retiro.
                int? cdPorCp = domicilioRetiro != null
                    ? ResolverCDActualIdPorCodigoPostal(domicilioRetiro.CodigoPostal)
                    : null;
                guia.CDOrigenId = cdPorCp ?? cdTrabajoId;   // fallback si el CP no resuelve

                // El domicilio de retiro es el que aporta el formulario.
                guia.DomicilioRetiro = domicilioRetiro;

                // Regla 3: el CD actual queda en null.
                guia.CDActualId = null;

                // Regla de estado: a domicilio la guía nace "A retirar".
                guia.Estado = EstadoGuiaEnum.A_RETIRAR;
            }
            else if (ModalidadImposicionActual == ModalidadImposicionEnum.AGENCIA)
            {
                Agencia agenciaTrabajo = ResolverAgenciaTrabajo();

                // Regla 6: agencia de origen = agencia de trabajo (Program.agenciaTrabajoId).
                guia.AgenciaOrigenId = agenciaTrabajoId;

                // Regla 7: CD de origen = CD asignado a la agencia (FK CDAsignadoId -> CentroDistribucion).
                guia.CDOrigenId = agenciaTrabajo != null ? agenciaTrabajo.CDAsignadoId : cdTrabajoId;

                // Regla 8: domicilio de retiro = domicilio de la agencia de trabajo.
                guia.DomicilioRetiro = agenciaTrabajo?.Domicilio;

                // Regla 9: el CD actual es 0.
                guia.CDActualId = 0;

                // Regla 10: en agencia la guía nace "A retirar".
                guia.Estado = EstadoGuiaEnum.A_RETIRAR;
            }
            else // ModalidadImposicionEnum.CD
            {
                // Regla 1: la agencia de origen es 0.
                guia.AgenciaOrigenId = 0;

                // Regla 2: el CD de origen es el CD de trabajo (Program.CDTrabajoId).
                guia.CDOrigenId = cdTrabajoId;

                // Regla 3: imposición directa en CD, sin domicilio de retiro.
                guia.DomicilioRetiro = null;

                // Regla 4: el CD actual es el CD de trabajo.
                guia.CDActualId = cdTrabajoId;

                // Regla 5: imposición directa en CD nace "Rendida".
                guia.Estado = EstadoGuiaEnum.RENDIDA;
            }
        }

        // Ubica la agencia de trabajo (Program.agenciaTrabajoId) dentro del padrón.
        private Agencia ResolverAgenciaTrabajo()
        {
            foreach (Agencia a in LAgencias)
                if (a.AgenciaId == agenciaTrabajoId)
                    return a;
            return null;
        }

        public int? ResolverCDActualIdPorCodigoPostal(string codigoPostal)
        {
            if (string.IsNullOrWhiteSpace(codigoPostal))
                return null;

            // Regla 1: buscar una agencia cuya lista de cobertura contenga el CP
            foreach (Agencia agencia in LAgencias)
            {
                foreach (string cpCobertura in agencia.CodigosPostalesCobertura)
                {
                    if (cpCobertura.Trim().ToUpper() == codigoPostal.Trim().ToUpper())
                        return agencia.CDAsignadoId;
                }
            }

            // Regla 2 (fallback): ninguna agencia cubre ese CP
            // Buscar la localidad cuyo CodigoPostalPrincipal coincida con el CP
            Localidad localidadEncontrada = null;
            foreach (Localidad localidad in LLocalidades)
            {
                if (localidad.CodigoPostalPrincipal.Trim().ToUpper() == codigoPostal.Trim().ToUpper())
                {
                    localidadEncontrada = localidad;
                    break;
                }
            }

            if (localidadEncontrada == null)
                return null;

            // Con la provincia de esa localidad, buscar el primer CD que esté en la misma provincia
            int provinciaId = localidadEncontrada.ProvinciaId;

            foreach (CentroDistribucion cd in LCentrosDistribucion)
            {
                if (cd.Domicilio == null)
                    continue;

                foreach (Localidad localidad in LLocalidades)
                {
                    if (localidad.LocalidadId == cd.Domicilio.LocalidadId &&
                        localidad.ProvinciaId  == provinciaId)
                    {
                        return cd.CDId;
                    }
                }
            }

            return null;
        }

        // ─────────────────────────────────────────────────────────────────────

        public void RegistrarGuia(Guia guia)
        {
            int nuevoId = GuiaAlmacen.guias.Count > 0
                ? GuiaAlmacen.guias.Max(g => g.GuiaId) + 1
                : 1;

            guia.GuiaId          = nuevoId;
            guia.FechaImposicion = DateTime.Now;

            var entidad = new GuiaEntidad
            {
                GuiaId                = guia.GuiaId,
                ClienteId             = guia.ClienteId,
                AgenciaOrigenId       = guia.AgenciaOrigenId ?? 0,
                AgenciaDestinoId      = guia.AgenciaDestinoId ?? 0,
                CDOrigenId            = guia.CDOrigenId,
                CDDestinoId           = guia.CDDestinoId,
                CDActualId            = guia.CDActualId ?? 0,
                ModalidadImposicion   = (Almacenes.ModalidadImposicionEnum)guia.ModalidadImposicion,
                DomicilioRetiro       = guia.DomicilioRetiro != null ? new Almacenes.Domicilio
                {
                    Calle        = guia.DomicilioRetiro.Calle,
                    Numero       = guia.DomicilioRetiro.Numero,
                    CodigoPostal = guia.DomicilioRetiro.CodigoPostal,
                    LocalidadId  = guia.DomicilioRetiro.LocalidadId
                } : null,
                ModalidadEntrega      = (Almacenes.ModalidadEntregaEnum)guia.ModalidadEntrega,
                NombreDestinatario    = guia.NombreDestinatario,
                ApellidoDestinatario  = guia.ApellidoDestinatario,
                DniDestinatario       = guia.DNIDestinatario,
                TipoCaja              = (Almacenes.TipoCajaEnum)guia.TipoCaja,
                DomicilioEntrega      = guia.DomicilioEntrega != null ? new Almacenes.Domicilio
                {
                    Calle        = guia.DomicilioEntrega.Calle,
                    Numero       = guia.DomicilioEntrega.Numero,
                    CodigoPostal = guia.DomicilioEntrega.CodigoPostal,
                    LocalidadId  = guia.DomicilioEntrega.LocalidadId
                } : null,
                IntentosDeEntrega     = guia.IntentosDeEntrega,
                Estado                = (Almacenes.EstadoGuiaEnum)guia.Estado,
                TarifarioId           = guia.TarifarioId,
                ObservacionesAdmision = guia.ObservacionesAdmision
            };

            GuiaAlmacen.guias.Add(entidad);
            GuiaAlmacen.Guardar();

            // Huella del estado inicial de la guía en el almacén de movimientos.
            RegistrarMovimientoInicial(guia);
        }

        // Deja registrado el estado inicial de la guía en MovimientoEstadoGuiaAlmacen.
        // Toda alta de guía en imposición deja así su primer movimiento de estado.
        private void RegistrarMovimientoInicial(Guia guia)
        {
            int nuevoMovimientoId = MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Count > 0
                ? MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Max(m => m.MovimientoId) + 1
                : 1;

            MovimientoEstadoGuiaEntidad movimiento = new MovimientoEstadoGuiaEntidad
            {
                MovimientoId    = nuevoMovimientoId,
                GuiaId          = guia.GuiaId,
                FechaMovimiento = DateTime.Now,
                Estado          = (Almacenes.EstadoGuiaEnum)guia.Estado,
                Ubicacion       = ResolverUbicacionInicial(guia)
            };

            MovimientoEstadoGuiaAlmacen.movimientoEstadoGuias.Add(movimiento);
            MovimientoEstadoGuiaAlmacen.Guardar();
        }

        // Describe dónde queda la guía según la modalidad de imposición,
        // siguiendo las convenciones de ubicación ya usadas en el sistema.
        private string ResolverUbicacionInicial(Guia guia)
        {
            switch (guia.ModalidadImposicion)
            {
                case ModalidadImposicionEnum.AGENCIA:
                    return $"En Agencia: {guia.AgenciaOrigenId ?? 0}";
                case ModalidadImposicionEnum.CD:
                    return $"En CD: {guia.CDOrigenId}";
                default: // DOMICILIO
                    return $"En Domicilio cliente: {guia.CDOrigenId}";
            }
        }

        public List<Localidad> ObtenerLocalidadesPorProvincia(int provinciaId)
        {
            List<Localidad> resultado = new List<Localidad>();
            foreach (var localidad in LLocalidades)
            {
                if (localidad.ProvinciaId == provinciaId)
                    resultado.Add(localidad);
            }
            return resultado;
        }

        public List<Agencia> ObtenerAgenciasPorLocalidad(int localidadId)
        {
            List<Agencia> resultado = new List<Agencia>();
            foreach (var agencia in LAgencias)
            {
                if (agencia.Domicilio != null && agencia.Domicilio.LocalidadId == localidadId)
                    resultado.Add(agencia);
            }
            return resultado;
        }

        public List<CentroDistribucion> ObtenerCDsPorLocalidad(int localidadId)
        {
            List<CentroDistribucion> resultado = new List<CentroDistribucion>();
            foreach (var cd in LCentrosDistribucion)
            {
                if (cd.Domicilio != null && cd.Domicilio.LocalidadId == localidadId)
                    resultado.Add(cd);
            }
            return resultado;
        }

        public bool ValidarCuit(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit)) return false;

            string soloDigitos = "";
            foreach (char c in cuit)
            {
                if (char.IsDigit(c))
                    soloDigitos = soloDigitos + c;
            }
            cuit = soloDigitos;

            if (cuit.Length != 11) return false;

            int prefijo = int.Parse(cuit.Substring(0, 2));
            if (prefijo != 20 && prefijo != 23 && prefijo != 24 &&
                prefijo != 27 && prefijo != 30 && prefijo != 33 && prefijo != 34)
                return false;

            int[] coef = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;
            for (int i = 0; i < 10; i++)
                suma = suma + (cuit[i] - '0') * coef[i];

            int resto = suma % 11;
            if (resto == 1) return false;

            int esperado = resto == 0 ? 0 : 11 - resto;
            return (cuit[10] - '0') == esperado;
        }
    }
}
