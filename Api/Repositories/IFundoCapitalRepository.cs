using System;
using System.Collections.Generic;
using SimpleExampleApiNetCore.Api.Models;

namespace SimpleExampleApiNetCore.Api.Repositories
{
    public interface IFundoCapitalRepository
    {
        void Adicionar(FundoCapital fundo);
        void Alterar(FundoCapital fundo);
        IEnumerable<FundoCapital> ListarFundos();
        FundoCapital ObterPorId(int id);
        void RemoverFundo(FundoCapital capital);
    }    
}