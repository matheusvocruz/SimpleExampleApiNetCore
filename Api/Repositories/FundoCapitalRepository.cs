using System;
using System.Collections.Generic;
using System.Linq;
using Api;
using SimpleExampleApiNetCore.Api.Models;

namespace SimpleExampleApiNetCore.Api.Repositories
{
    public class FundoCapitalRepository : IFundoCapitalRepository
    {
        private readonly DefaultContext _context;

        public FundoCapitalRepository(DefaultContext context)
        {
            _context = context;
        }

        public void Adicionar(FundoCapital fundo)
        {
            _context.FundoCapital.Add(fundo);
            _context.SaveChanges();
        }

        public void Alterar(FundoCapital fundo)
        {
            _context.FundoCapital.Update(fundo);
            _context.SaveChanges();
        }

        public IEnumerable<FundoCapital> ListarFundos()
        {
            return _context.FundoCapital.ToList();
        }

        public FundoCapital ObterPorId(int id)
        {
            return _context.FundoCapital.FirstOrDefault(x => x.Id == id);
        }

        public void RemoverFundo(FundoCapital fundo)
        {
            _context.FundoCapital.Remove(fundo);
            _context.SaveChanges();
        }
    }
}