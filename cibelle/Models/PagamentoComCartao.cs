using System.ComponentModel.DataAnnotations;
namespace cibelle.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "Número do cartão")]
        public string NumeroDoCartao { get; set; }
        public string Bandeira { get; set; }

    }
}