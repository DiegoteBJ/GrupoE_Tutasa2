using System;
using System.Collections.Generic;
using System.Text;

namespace GrupoE_Tutasa.EmitirFactura
{
    internal class EmisionFacturaModelo
    {
        public List<GuiasPendientes> LGuiasPendientes
        {
            get
            {
                return new List<GuiasPendientes>
                {
                    //Esta clase representa las guias pendientes de facturacion, Cada guia tiene un Id unico, un clienteID 
                    //sruge en realidad de la clase CC de Clientes, guia id, fecha de entrega, fecha de movimiento, 
                    //precio de imposicion, transporte, entrega y total. Un boolean que indique si ya fue facturada
                    // y un string con el numero de cocumento una vez facturada.

                    new GuiasPendientes { Id = 1, clienteID = 1, numeroGuia = 001, fechaEntrega = new DateTime(2026, 04, 05), importe = 15000 },
                    new GuiasPendientes { Id = 2, clienteID = 2, numeroGuia = 002, fechaEntrega = new DateTime(2026, 04, 06), importe = 10000 },
                    new GuiasPendientes { Id = 3, clienteID = 3, numeroGuia = 003, fechaEntrega = new DateTime(2026, 04, 07), importe = 6000 },
                    new GuiasPendientes { Id = 4, clienteID = 4, numeroGuia = 004, fechaEntrega = new DateTime(2026, 04, 08), importe = 20000 },
                    new GuiasPendientes { Id = 5, clienteID = 5, numeroGuia = 005, fechaEntrega = new DateTime(2026, 04, 09), importe = 11000 },
                    new GuiasPendientes { Id = 6, clienteID = 6, numeroGuia = 006, fechaEntrega = new DateTime(2026, 04, 10), importe = 7000 },
                    new GuiasPendientes { Id = 7, clienteID = 1, numeroGuia = 007, fechaEntrega = new DateTime(2026, 04, 11), importe = 19000 },
                    new GuiasPendientes { Id = 8, clienteID = 2, numeroGuia = 008, fechaEntrega = new DateTime(2026, 04, 12), importe = 14000 },
                    new GuiasPendientes { Id = 9, clienteID = 3, numeroGuia = 009, fechaEntrega = new DateTime(2026, 04, 13), importe = 9500 },
                    new GuiasPendientes { Id = 10, clienteID = 4, numeroGuia = 010, fechaEntrega = new DateTime(2026, 04, 14), importe = 7500 },
                    new GuiasPendientes { Id = 11, clienteID = 1, numeroGuia = 011, fechaEntrega = new DateTime(2026, 04, 15), importe = 20000 },
                    new GuiasPendientes { Id = 12, clienteID = 2, numeroGuia = 012, fechaEntrega = new DateTime(2026, 04, 16), importe = 15000 },
                    new GuiasPendientes { Id = 13, clienteID = 3, numeroGuia = 013, fechaEntrega = new DateTime(2026, 04, 17), importe = 10000 },
                    new GuiasPendientes { Id = 14, clienteID = 4, numeroGuia = 014, fechaEntrega = new DateTime(2026, 04, 18), importe = 6000 },
                    new GuiasPendientes { Id = 15, clienteID = 1, numeroGuia = 015, fechaEntrega = new DateTime(2026, 04, 19), importe = 20000 },
                    new GuiasPendientes { Id = 16, clienteID = 2, numeroGuia = 016, fechaEntrega = new DateTime(2026, 04, 20), importe = 14000 },
                    new GuiasPendientes { Id = 17, clienteID = 3, numeroGuia = 017, fechaEntrega = new DateTime(2026, 04, 21), importe = 11000 },
                    new GuiasPendientes { Id = 18, clienteID = 4, numeroGuia = 018, fechaEntrega = new DateTime(2026, 04, 22), importe = 7000 },
                    new GuiasPendientes { Id = 19, clienteID = 5, numeroGuia = 019, fechaEntrega = new DateTime(2026, 04, 23), importe = 19000 },
                    new GuiasPendientes { Id = 20, clienteID = 1, numeroGuia = 020, fechaEntrega = new DateTime(2026, 04, 24), importe = 15000 }
                };
            }
        }
        public List<Clientes> LClientes
        {
            get
            {
                return new List<Clientes>
                {
                    new Clientes { clienteId = 1, clienteName = "Cliente A", clienteCUIT = "30654364229" },
                    new Clientes { clienteId = 2, clienteName = "Cliente B", clienteCUIT = "27202016494" },
                    new Clientes { clienteId = 3, clienteName = "Cliente C", clienteCUIT = "20483900334" },
                    new Clientes { clienteId = 4, clienteName = "Cliente D", clienteCUIT = "20483900342" },
                    new Clientes { clienteId = 5, clienteName = "Cliente E", clienteCUIT = "20329642330" },
                    new Clientes { clienteId = 6, clienteName = "Cliente F", clienteCUIT = "27384592017" },
                    new Clientes { clienteId = 7, clienteName = "Cliente G", clienteCUIT = "30765432109" },
                    new Clientes { clienteId = 8, clienteName = "Cliente H", clienteCUIT = "23345678903" },
                    new Clientes { clienteId = 9, clienteName = "Cliente I", clienteCUIT = "30789123456" },
                    new Clientes { clienteId = 10, clienteName = "Cliente J", clienteCUIT = "20345678901" },
                };
            }
        }
        public List<Documentos> LDocumentos
        {
            get
            {
                return new List<Documentos>
                {
                    new Documentos { documentoId = 1, clienteId = 1, documentoTipo = "Factura", documentoFecha = new DateTime(2026, 01, 01), documentoNumero = "F001-00000001", netoGravado = 10000,  ivaDF = 2100, documentoTotal = 12100 },
                    new Documentos { documentoId = 2, clienteId = 2, documentoTipo = "Factura", documentoFecha = new DateTime(2026, 01, 02), documentoNumero = "F001-00000002", netoGravado = 15000,  ivaDF = 3150, documentoTotal = 18150 },
                    new Documentos { documentoId = 3, clienteId = 3, documentoTipo = "Factura", documentoFecha = new DateTime(2026, 01, 03), documentoNumero = "F001-00000003", netoGravado = 20000,  ivaDF = 4200, documentoTotal = 24200 },
                    new Documentos { documentoId = 4, clienteId = 4, documentoTipo = "Factura", documentoFecha = new DateTime(2026, 01, 04), documentoNumero = "F001-00000004", netoGravado = 25000,  ivaDF = 5250, documentoTotal = 30250 },
                    new Documentos { documentoId = 5, clienteId = 5, documentoTipo = "Factura", documentoFecha = new DateTime(2026, 01, 05), documentoNumero = "F001-00000005", netoGravado = 30000,  ivaDF = 6300, documentoTotal = 36300 }
                };
            }
        }
        public List<Guias> LGuias
        //Esta clase sale de la clase Guias para obtener los datos que falta para presentar en la pantalla y que
        //el operador pueda visualizar lo que esta facturando. Necesitamos guiaID, el clienteID, apellido y nombre del destinatario
        // tipo de caja, tarifarioID. El resto de los datos se pueden obtener de la clase GuiasPendientes, como fecha de entrega.  
        {
            get
            {
                return new List<Guias>
                {
                    new Guias { guiaId = 1, clienteId = 1, fechaImposicion = new DateTime(2026, 01, 01), apellidoDestinatario="Gonzalez", nombreDestinatario = "Jorge", tipoCaja="L", tarifarioId = 1 },
                    new Guias { guiaId = 2, clienteId = 2, fechaImposicion = new DateTime(2026, 01, 02), apellidoDestinatario="Perez", nombreDestinatario = "Maria", tipoCaja = "X", tarifarioId = 1 },
                    new Guias { guiaId = 3, clienteId = 3, fechaImposicion = new DateTime(2026, 01, 03), apellidoDestinatario="Garcia", nombreDestinatario = "Carlos", tipoCaja = "S", tarifarioId = 1 },
                    new Guias { guiaId = 4, clienteId = 4, fechaImposicion = new DateTime(2026, 01, 04), apellidoDestinatario="Flores", nombreDestinatario = "Ana", tipoCaja = "L", tarifarioId = 1 },
                    new Guias { guiaId = 5, clienteId = 5, fechaImposicion = new DateTime(2026, 01, 05), apellidoDestinatario="DellaSalla", nombreDestinatario = "Luis", tipoCaja = "X", tarifarioId = 1 },
                    new Guias { guiaId = 6, clienteId = 6, fechaImposicion = new DateTime(2026, 01, 06), apellidoDestinatario="Conte", nombreDestinatario = "Elena", tipoCaja = "S", tarifarioId = 1 },
                    new Guias { guiaId = 7, clienteId = 1, fechaImposicion = new DateTime(2026, 01, 07), apellidoDestinatario="Djokeres", nombreDestinatario = "Juan", tipoCaja = "L", tarifarioId = 1 },
                    new Guias { guiaId = 8, clienteId = 2, fechaImposicion = new DateTime(2026, 01, 08), apellidoDestinatario="Saka", nombreDestinatario = "María", tipoCaja = "X", tarifarioId = 1 },
                    new Guias { guiaId = 9, clienteId = 3, fechaImposicion = new DateTime(2026, 01, 09), apellidoDestinatario="Paredes", nombreDestinatario = "Carlos", tipoCaja = "XL", tarifarioId = 1 },
                    new Guias { guiaId = 10, clienteId = 4, fechaImposicion = new DateTime(2026, 01, 10), apellidoDestinatario="Merentiel", nombreDestinatario = "Ana", tipoCaja = "L", tarifarioId = 1 },
                    new Guias { guiaId = 11, clienteId = 1, fechaImposicion = new DateTime(2026, 01, 11), apellidoDestinatario="Delgado", nombreDestinatario = "Luis", tipoCaja = "X", tarifarioId = 1 },
                    new Guias { guiaId = 12, clienteId = 2, fechaImposicion = new DateTime(2026, 01, 12), apellidoDestinatario="Pedraza", nombreDestinatario = "María", tipoCaja = "S", tarifarioId = 1 },
                    new Guias { guiaId = 13, clienteId = 3, fechaImposicion = new DateTime(2026, 01, 17), apellidoDestinatario="Torres", nombreDestinatario = "Carlos", tipoCaja = "L", tarifarioId = 1 },
                    new Guias { guiaId = 14, clienteId = 4, fechaImposicion = new DateTime(2026, 01, 18), apellidoDestinatario="Reyna", nombreDestinatario = "Ana", tipoCaja = "X", tarifarioId = 1 },
                    new Guias { guiaId = 15, clienteId = 1, fechaImposicion = new DateTime(2026, 01, 19), apellidoDestinatario="Gonzalez", nombreDestinatario = "Jorge", tipoCaja = "L", tarifarioId = 1 },
                    new Guias { guiaId = 16, clienteId = 2, fechaImposicion = new DateTime(2026, 01, 20), apellidoDestinatario="Perez", nombreDestinatario = "Maria", tipoCaja = "X", tarifarioId = 1 },
                    new Guias { guiaId = 17, clienteId = 3, fechaImposicion = new DateTime(2026, 01, 13), apellidoDestinatario="Torres", nombreDestinatario = "Carlos", tipoCaja = "L", tarifarioId = 1 },
                    new Guias { guiaId = 18, clienteId = 4, fechaImposicion = new DateTime(2026, 01, 14), apellidoDestinatario="Reyna", nombreDestinatario = "Ana", tipoCaja = "X", tarifarioId = 1 },
                    new Guias { guiaId = 19, clienteId = 5, fechaImposicion = new DateTime(2026, 01, 06), apellidoDestinatario="Gimenez", nombreDestinatario = "Luis", tipoCaja = "S", tarifarioId = 1 },
                    new Guias { guiaId = 20, clienteId = 1, fechaImposicion = new DateTime(2026, 01, 06), apellidoDestinatario="Lopez", nombreDestinatario = "Jorge", tipoCaja = "XL", tarifarioId = 1 }
                };
            }
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