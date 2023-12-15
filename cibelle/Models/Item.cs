using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cibelle.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int Percentual { get; set; }
        public int IdNotaDeVenda { get; set; }
        public NotaDeVenda NotaDeVenda { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
    }
}