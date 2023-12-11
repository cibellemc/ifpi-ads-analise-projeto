using System.ComponentModel.DataAnnotations;

namespace cibelle.Models
{
    public class Item
    {
        public string Id { get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public int Percentual { get; set; }
        public List<NotaDeVenda> NotasDeVenda { get; set; }

    }
}