using System;

namespace SimpleExampleApiNetCore.Api.Models 
{
    public class FundoCapital
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorNecessario { get; set; }
        public decimal ValorAtual { get; set; }
        public DateTime? DataResgate { get; set; }
    }
}