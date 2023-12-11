namespace cibelle.Models
{
    public class Pagamento
    {
        public string Id { get; set; }
        public double Valor { get; set; }
        public bool Pago { get; set; }
        public DateTime DataLimite { get; set; }
        public NotaDeVenda NotaDeVenda { get; set; }
    }
}