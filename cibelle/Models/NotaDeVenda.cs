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
        public List<int> IdsItems { get; set; } = new List<int>();
        public List<Item> Itens { get; set; } // Relação com Item

        public void AssociarProdutos(List<Produto> produtos/*, List<int> quantidades*/)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                var produto = produtos[i];
                // var quantidade = quantidades[i];

                var item = new Item
                {
                    Produto = produto,
                    Preco = produto.Preco,
                    // Quantidade = quantidade,
                    // Percentual = 0
                };

                Itens.Add(item);
            }
        }

        public decimal CalcularValorTotal()
        {
            return Itens.Sum(item => item.Preco);
        }
    }
}

