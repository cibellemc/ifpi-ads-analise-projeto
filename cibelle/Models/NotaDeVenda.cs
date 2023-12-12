using System.ComponentModel.DataAnnotations.Schema;

namespace cibelle.Models
{
    public class NotaDeVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdVendedor { get; set; }
        public Vendedor Vendedor { get; set; }
        public int IdTransportadora { get; set; }
        public Transportadora Transportadora { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
        public int IdTipoPagamento { get; set; }
        public TipoDePagamento TipoDePagamento { get; set; }
        [NotMapped]
        public List<int> IdsItems { get; set; }
        public List<Item> Itens { get; set; } // Relação com Item
    }
}