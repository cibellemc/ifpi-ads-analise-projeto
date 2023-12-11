namespace cibelle.Models
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public List<NotaDeVenda> NotasDeVenda { get; set; }

    }
}