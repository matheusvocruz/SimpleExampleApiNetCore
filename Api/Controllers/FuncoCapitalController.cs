using System;
using SimpleExampleApiNetCore.Api.Models;
using Microsoft.AspNetCore.Mvc;
using SimpleExampleApiNetCore.Api.Repositories;

namespace SimpleExampleApiNetCore.Api.Controllers
{

    public class FundoCapitalController : Controller 
    {
        private readonly IFundoCapitalRepository _repositorio;

        public FundoCapitalController(IFundoCapitalRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("v1/fundoscapital")]
        public IActionResult ListarFundos()
        {
            return Ok(_repositorio.ListarFundos());
        }

        [HttpPost("v1/fundoscapital")]
        public IActionResult AdicionarFundo([FromBody] FundoCapital fundo)
        {
            _repositorio.Adicionar(fundo);
            return Ok();
        }

        [HttpPut("v1/fundoscapital/{id}")]
        public IActionResult AlterarFundo(Guid id, [FromBody] FundoCapital fundo)
        {
            var fundoAntigo = _repositorio.ObterPorId(id);

            if(fundoAntigo == null){
                return NotFound();
            }

            fundoAntigo.Nome = fundo.Nome;
            fundoAntigo.ValorAtual = fundo.ValorAtual;
            fundoAntigo.ValorNecessario = fundo.ValorNecessario;
            fundoAntigo.DataResgate = fundo.DataResgate;
            _repositorio.Alterar(fundoAntigo);

            return Ok();
        }

        [HttpGet("v1/fundoscapital/{id}")]
        public IActionResult ObterFundo(Guid id)
        {
            var fundoAntigo = _repositorio.ObterPorId(id);

            if(fundoAntigo == null){
                return NotFound();
            }

            return Ok(fundoAntigo);
        }

        [HttpDelete("v1/fundoscapital/{id}")]
        public IActionResult RemoverFundo(Guid id)
        {
            var fundo = _repositorio.ObterPorId(id);

            if(fundo == null){
                return NotFound();
            }

            _repositorio.RemoverFundo(fundo);

            return Ok();
        }
    }
}