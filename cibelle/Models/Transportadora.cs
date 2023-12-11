namespace cibelle.Models
{
    public class Transportadora
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public List<NotaDeVenda> NotasDeVenda { get; set; }
    }
}