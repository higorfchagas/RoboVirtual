using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetoRoboNddTech.Data;
using ProjetoRoboNddTech.Models;
using ProjetoRoboNddTech.Services;
using ProjetoRoboNddTech.DTO;

namespace ProjetoRoboNddTech.Controllers
{
    [ApiController]
    [Route("Robo")]
    public class RoboController : ControllerBase
    {
        [HttpPost]
        [Route("/Status/{idRobo}")]
        public ActionResult<RoboDTO> CapturarStatusRobo([FromServices] DataContext context, int idRobo)
        {
            try
            {
                var resultadoAcao = context.Robo
                .Where(x => x.RoboId == idRobo)
                .AsNoTracking()
                .Select(x => new RoboDTO
                {
                    Id = x.RoboId,
                    Nome = x.Nome,
                    CabecaInclinacao = x.MovimentoCabecaInclinacao.CabecaInclinacaoMovimentoDescricao,
                    CabecaRotacao = x.MovimentoCabecaRotacao.CabecaRotacaoMovimentoDescricao,
                    BracoDireitoCotovelo = x.MovimentoBracoCotoveloDireito.BracoCotoveloMovimentoDescricao,
                    BracoEsquerdoCotovelo = x.MovimentoBracoCotoveloEsquerdo.BracoCotoveloMovimentoDescricao,
                    BracoDireitoPulso = x.MovimentoBracoPulsoDireito.BracoPulsoMovimentoDescricao,
                    BracoEsquerdoPulso = x.MovimentoBracoPulsoEsquerdo.BracoPulsoMovimentoDescricao,

                }).First();

                if (resultadoAcao == null)
                    return NotFound();

                return resultadoAcao;
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }

        [HttpGet]
        [Route("/Movimento/Rotacao")]
        public ActionResult<List<MovimentoExecutadoDTO>> CapturarMovimentosRotacaoCabeca([FromServices] DataContext context)
        {
            try
            {
                var movimentosCabecaRotacao = context.CabecaRotacaoMovimento
                .AsNoTracking()
                .Select(x => new MovimentoExecutadoDTO
                {
                    Id = x.CabecaRotacaoMovimentoId,
                    Descricao = x.CabecaRotacaoMovimentoDescricao,
                }).ToList();

                if (movimentosCabecaRotacao == null)
                    return NotFound();

                return movimentosCabecaRotacao;
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }

        [HttpGet]
        [Route("/Movimento/Inclinacao")]
        public ActionResult<List<MovimentoExecutadoDTO>> CapturarMovimentosInclinacaoCabeca([FromServices] DataContext context)
        {
            try
            {
                var movimentosCabecaInclinacao = context.CabecaInclinacaoMovimento
                .AsNoTracking()
                .Select(x => new MovimentoExecutadoDTO
                {
                    Id = x.CabecaInclinacaoMovimentoId,
                    Descricao = x.CabecaInclinacaoMovimentoDescricao,
                }).ToList();

                if (movimentosCabecaInclinacao == null)
                    return NotFound();

                return movimentosCabecaInclinacao;
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }

        [HttpGet]
        [Route("/Movimento/Braco/Cotovelo")]
        public ActionResult<List<MovimentoExecutadoDTO>> CapturarMovimentosBracoCotovelo([FromServices] DataContext context)
        {
            try
            {
                var bracoCotoveloMovimento = context.BracoCotoveloMovimento
                .AsNoTracking()
                .Select(x => new MovimentoExecutadoDTO
                {
                    Id = x.BracoCotoveloMovimentoId,
                    Descricao = x.BracoCotoveloMovimentoDescricao,
                }).ToList();

                if (bracoCotoveloMovimento == null)
                    return NotFound();

                return bracoCotoveloMovimento;
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }

        [HttpGet]
        [Route("/Movimento/Braco/Pulso")]
        public ActionResult<List<MovimentoExecutadoDTO>> CapturarMovimentosBracoPulso([FromServices] DataContext context)
        {
            try
            {
                var bracoPulsoMovimento = context.BracoPulsoMovimento
                .AsNoTracking()
                .Select(x => new MovimentoExecutadoDTO
                {
                    Id = x.BracoPulsoMovimentoId,
                    Descricao = x.BracoPulsoMovimentoDescricao,
                }).ToList();

                if (bracoPulsoMovimento == null)
                    return NotFound();

                return bracoPulsoMovimento;
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }
    }
}
