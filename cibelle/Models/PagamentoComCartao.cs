using System;
namespace cibelle.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        public string NumeroDoCartao { get; set; }
        public string Bandeira { get; set; }

    }
}