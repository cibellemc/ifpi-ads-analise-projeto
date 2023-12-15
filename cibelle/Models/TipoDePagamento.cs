using System.ComponentModel.DataAnnotations;

namespace cibelle.Models
{
    public class TipoDePagamento
    {
        public int Id { get; set; }
        [Display(Name = "Nome do titular")]
        public string NomeDoCobrado { get; set; }
        [Display(Name = "Informações adicionais")]
        public string InformacoesAdicionais { get; set; }
        public List<NotaDeVenda> NotasDeVenda { get; set; }
    }
}