namespace cibelle.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        public string NomeDoBanco { get; set; }
        public int Banco { get; set; }
    }
}