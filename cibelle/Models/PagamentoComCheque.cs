using System.ComponentModel.DataAnnotations;

namespace cibelle.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Nome do banco")]
        public string NomeDoBanco { get; set; }
        public int Banco { get; set; }
    }
}