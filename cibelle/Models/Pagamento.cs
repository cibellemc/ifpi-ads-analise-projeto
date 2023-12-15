using System.ComponentModel.DataAnnotations;

namespace cibelle.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        [Display(Name = "Data Limite")]
        public DateTime DataLimite { get; set; }
        [Display(Name = "Código da nota")]
        public int IdNotaDeVenda { get; set; }
        public NotaDeVenda NotaDeVenda { get; set; }
    }
}