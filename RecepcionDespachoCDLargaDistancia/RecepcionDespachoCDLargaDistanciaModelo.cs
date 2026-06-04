using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using GrupoE_Tutasa.RecepcionDespachoCDLargaDistancia;

namespace GrupoE_Tutasa.RecepcionDespachoCDLargaDistancia
{
    internal class RecepcionDespachoCDLargaDistanciaModelo
    {
        private readonly Dictionary<string, ServicioTransporte> _servicios = new()
        {
            ["001"] = new ServicioTransporte
            {
                ServicioId = "001",
                NombreEmpresa = "Transporte del Sur S.A.",
                FechaSalida = new DateTime(2026, 5, 30, 8, 0, 0),
                Ruta = "Buenos Aires - Córdoba",
                HDRsARecibir = new List<HDRTransporte>
                {
                    new HDRTransporte { HdrTransporteId = 1, NroGuia = "BA-00123", Destino = "Buenos Aires", Tamaño = "M", Estado = "EnTransito" },
                    new HDRTransporte { HdrTransporteId = 2, NroGuia = "BA-00124", Destino = "Buenos Aires", Tamaño = "L", Estado = "EnTransito" }
                },
                HDRsADespachar = new List<HDRTransporte>
                {
                    new HDRTransporte { HdrTransporteId = 3, NroGuia = "BA-00125", Destino = "Córdoba", Tamaño = "XL", Estado = "Pendiente" },
                    new HDRTransporte { HdrTransporteId = 4, NroGuia = "BA-00126", Destino = "Córdoba", Tamaño = "S",  Estado = "Pendiente" }
                }
            },
            ["002"] = new ServicioTransporte
            {
                ServicioId = "002",
                NombreEmpresa = "Fletes del Norte S.R.L.",
                FechaSalida = new DateTime(2026, 5, 29, 14, 30, 0),
                Ruta = "Buenos Aires - Rosario",
                HDRsARecibir = new List<HDRTransporte>
                {
                    new HDRTransporte { HdrTransporteId = 5, NroGuia = "BA-00201", Destino = "Buenos Aires", Tamaño = "S", Estado = "EnTransito" }
                },
                HDRsADespachar = new List<HDRTransporte>
                {
                    new HDRTransporte { HdrTransporteId = 6, NroGuia = "BA-00202", Destino = "Rosario", Tamaño = "M", Estado = "Pendiente" },
                    new HDRTransporte { HdrTransporteId = 7, NroGuia = "BA-00203", Destino = "Rosario", Tamaño = "L", Estado = "Pendiente" }
                }
            }
        };

        // Excepción 3.5 — campo vacío
        public bool EsNroVacio(string nro)
            => string.IsNullOrWhiteSpace(nro);

        // Excepción 3.1 — letras o caracteres especiales
        public bool TieneFormatoInvalido(string nro)
            => !Regex.IsMatch(nro, @"^\d+$");

        // Excepción 3.3 — número no existe
        public bool ExisteServicio(string nro)
            => _servicios.ContainsKey(nro);

        public ServicioTransporte BuscarServicio(string nro)
        {
            _servicios.TryGetValue(nro, out var servicio);
            return servicio;
        }

        public void MarcarComoRecibidas(List<HDRTransporte> hdrs)
        {
            foreach (HDRTransporte hdr in hdrs)
                hdr.Estado = "Recibida";
        }

        public void MarcarComoEnTransito(List<HDRTransporte> hdrs)
        {
            foreach (HDRTransporte hdr in hdrs)
                hdr.Estado = "EnTransito";
        }
    }
}
