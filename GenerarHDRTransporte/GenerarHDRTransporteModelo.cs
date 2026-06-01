using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GrupoE_Tutasa.GenerarHDRTransporte
{
    internal class GenerarHDRTransporteModelo
    {
       
        
            // ── Datos de prueba ─────────────────
            private readonly Dictionary<string, ServicioTransporte> _servicios = new()
            {
                ["001"] = new ServicioTransporte
                {
                    ServicioId = "001",
                    NombreEmpresa = "Transporte del Sur S.A.",
                    FechaSalida = new DateTime(2026, 5, 30, 8, 0, 0),
                    Ruta = "Buenos Aires - Córdoba",
                    GuiasPendientes = new List<Guia>
                {
                    new Guia { NroGuia = "G-1001", Tamaño = "S",  Destino = "Córdoba" },
                    new Guia { NroGuia = "G-1002", Tamaño = "M",  Destino = "Córdoba" },
                    new Guia { NroGuia = "G-1003", Tamaño = "L",  Destino = "Córdoba" }
                }
                },
                ["002"] = new ServicioTransporte
                {
                    ServicioId = "002",
                    NombreEmpresa = "Fletes del Norte S.R.L.",
                    FechaSalida = new DateTime(2026, 5, 29, 14, 30, 0),
                    Ruta = "Buenos Aires - Rosario",
                    GuiasPendientes = new List<Guia>
                {
                    new Guia { NroGuia = "G-3001", Tamaño = "S",  Destino = "Rosario" },
                    new Guia { NroGuia = "G-3002", Tamaño = "XL", Destino = "Rosario" }
                }
                },
                ["003"] = new ServicioTransporte
                {
                    ServicioId = "003",
                    NombreEmpresa = "Expreso del Litoral S.A.",
                    FechaSalida = new DateTime(2026, 5, 31, 10, 0, 0),
                    Ruta = "Buenos Aires - Santa Fe",
                    GuiasPendientes = new List<Guia>
                {
                    new Guia { NroGuia = "G-5001", Tamaño = "M",  Destino = "Santa Fe" },
                    new Guia { NroGuia = "G-5002", Tamaño = "S",  Destino = "Santa Fe" },
                    new Guia { NroGuia = "G-5003", Tamaño = "XL", Destino = "Santa Fe" },
                    new Guia { NroGuia = "G-5004", Tamaño = "S",  Destino = "Santa Fe" }
                }
                }
            };

            // Excepción 3.5 / 3.8 — campo vacío
            public bool EsNroVacio(string nro)
                => string.IsNullOrWhiteSpace(nro);

            // Excepción 3.1 / 3.2 — solo dígitos numéricos
            public bool TieneFormatoInvalido(string nro)
                => !Regex.IsMatch(nro, @"^\d+$");

            // Excepción 3.3 / 3.4 — número no existe
            public bool ExisteServicio(string nro)
                => _servicios.ContainsKey(nro);

            // Búsqueda exitosa
            public ServicioTransporte BuscarServicio(string nro)
            {
                _servicios.TryGetValue(nro, out var servicio);
                return servicio;
            }
        }
    }
