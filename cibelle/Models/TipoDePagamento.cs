namespace cibelle.Models
{
    public class TipoDePagamento
    {
        public string Id { get; set; }
        public string NomeDoCobrado { get; set; }
        public string InformacoesAdicionais { get; set; }
        public List<NotaDeVenda> NotasDeVenda { get; set; }
    }
}