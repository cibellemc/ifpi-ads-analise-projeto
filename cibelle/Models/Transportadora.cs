namespace cibelle.Models
{
    public class Transportadora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<NotaDeVenda> NotasDeVenda { get; set; }
    }
}