using System.ComponentModel.DataAnnotations;

namespace cibelle.Models
{
    public class Marca
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}