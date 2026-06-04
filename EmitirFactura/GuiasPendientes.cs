using System;
using System.Collections.Generic;
using System.Text;


namespace GrupoE_Tutasa.EmitirFactura
{
    internal class GuiasPendientes
    //Esta clase representa las guias pendientes de facturacion, Cada guia tiene un Id unico, un clienteID 
    //sruge en realidad de la clase CC de Clientes, guia id, fecha de entrega, fecha de movimiento, 
    //precio de imposicion, transporte, entrega y total. Un boolean que indique si ya fue facturada
    // y un string con el numero de cocumento una vez facturada.
    {
        public int Id { get; set; }
        public int clienteID { get; set; }
        public int numeroGuia { get; set; }
        public DateTime fechaEntrega { get; set; }
        public DateTime fechaMovimiento { get; set; }
        public decimal precioImposicion { get; set; } 
        public decimal precioEntrega { get; set; } 
        public decimal precioTransporte { get; set; } 
        public decimal importe { get; set; }
        public int empresaTransporteID { get; set; }
        public bool facturada { get; set; }
        public string documentoNumero { get; set; }

    }
}
