namespace GrupoE_Tutasa.Imposicion
{
    internal class Guia
    {
        public string   NumeroGuia           { get; set; }
        public DateTime FechaImposicion      { get; set; }
        public int      ClienteId            { get; set; }
        public string   TipoEncomienda       { get; set; }  // "S", "M", "L", "XL"
        public string   TipoEntrega          { get; set; }  // "Domicilio", "Agencia", "CD"
        public string   DireccionDestino     { get; set; }
        public string   CPDestino            { get; set; }
        public string   NombreDestinatario   { get; set; }
        public string   ApellidoDestinatario { get; set; }
        public long     DNIDestinatario      { get; set; }
        public string   Estado               { get; set; }  // "A retirar" / "Impuesta telefónicamente"
        public decimal  ImporteEstimado      { get; set; }
    }
}
