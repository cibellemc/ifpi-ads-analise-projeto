using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cibelle.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<NotaDeVenda> NotasDeVenda { get; set; }

    }
}