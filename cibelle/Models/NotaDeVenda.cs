namespace cibelle.Models
{
    public class NotaDeVenda
    {
        public string Id { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Transportadora Transportadora { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
        public TipoDePagamento TipoDePagamento { get; set; }
    }
}