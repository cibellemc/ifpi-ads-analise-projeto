using System.ComponentModel.DataAnnotations;

namespace cibelle.Models
{
    public class Produto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        public Marca Marca { get; set; }
        public List<Item> Itens { get; set; }
    }
}