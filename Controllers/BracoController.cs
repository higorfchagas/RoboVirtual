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
using Microsoft.AspNetCore.Http;

namespace ProjetoRoboNddTech.Controllers
{
    [ApiController]
    [Route("MovimentarBraco")]
    public class BracoController : ControllerBase
    {
        [HttpPut]
        [Route("Direito/Cotovelo/{idRobo}/{proximoMovimentoId}")]
        public ActionResult MovimentarBracoDireitoCotovelo([FromServices] DataContext context, int idRobo, int proximoMovimentoId)
        {
            try
            {
                var roboDB = context.Robo.Where(x => x.RoboId == idRobo).FirstOrDefault();
                if (roboDB == null)
                    return NotFound("Robo não encontrado");

                var movimento = context.BracoCotoveloMovimento.Where(i => i.BracoCotoveloMovimentoId == proximoMovimentoId).FirstOrDefault();
                if (movimento == null)
                    return NotFound("Movimento não encontrado");

                Utilitario utilitario = new Utilitario();

                if (!utilitario.VerificarProximoMovimento(proximoMovimentoId, roboDB.movimentoBracoCotoveloDireitoId))
                    return BadRequest("Movimento não permitido.");
                else
                {
                    roboDB.movimentoBracoCotoveloDireitoId = proximoMovimentoId;

                    context.Robo.Update(roboDB);
                    context.SaveChanges();

                    return StatusCode(StatusCodes.Status200OK);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }

        [HttpPut]
        [Route("Esquerdo/Cotovelo/{idRobo}/{proximoMovimentoId}")]
        public ActionResult MovimentarBracoEsquerdoCotovelo([FromServices] DataContext context, int idRobo, int proximoMovimentoId)
        {
            try
            {
                var roboDB = context.Robo.Where(x => x.RoboId == idRobo).FirstOrDefault();
                if (roboDB == null)
                    return NotFound("Robo não encontrado");

                var movimento = context.BracoCotoveloMovimento.Where(i => i.BracoCotoveloMovimentoId == proximoMovimentoId).FirstOrDefault();
                if (movimento == null)
                    return NotFound("Movimento não encontrado");

                Utilitario utilitario = new Utilitario();

                if (!utilitario.VerificarProximoMovimento(proximoMovimentoId, roboDB.movimentoBracoCotoveloEsquerdoId))
                    return BadRequest("Movimento não permitido.");
                else
                {
                    roboDB.movimentoBracoCotoveloEsquerdoId = proximoMovimentoId;

                    context.Robo.Update(roboDB);
                    context.SaveChanges();

                     return StatusCode(StatusCodes.Status200OK);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }

        [HttpPut]
        [Route("Direito/Pulso/{idRobo}/{proximoMovimentoId}")]
        public ActionResult MovimentarBracoDireitoPulso([FromServices] DataContext context, int idRobo, int proximoMovimentoId)
        {
            try
            {
                var roboDB = context.Robo.Where(x => x.RoboId == idRobo).FirstOrDefault();
                if (roboDB == null)
                    return NotFound("Robo não encontrado");

                var movimento = context.BracoPulsoMovimento.Where(i => i.BracoPulsoMovimentoId == proximoMovimentoId).FirstOrDefault();
                if (movimento == null)
                    return NotFound("Movimento não encontrado");

                Utilitario utilitario = new Utilitario();

                if (!utilitario.VerificarProximoMovimento(proximoMovimentoId, roboDB.movimentoBracoPulsoDireitoId))
                    return BadRequest("Movimento não permitido.");
                else if (!utilitario.VerificarPossibilidadeMovimentacaoPulso(roboDB.movimentoBracoCotoveloDireitoId))
                    return BadRequest("Movimento não permitido.");
                else
                {
                    roboDB.movimentoBracoPulsoDireitoId = proximoMovimentoId;

                    context.Robo.Update(roboDB);
                    context.SaveChanges();

                    return StatusCode(StatusCodes.Status200OK);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }

        [HttpPut]
        [Route("Esquerdo/Pulso/{idRobo}/{proximoMovimentoId}")]
        public ActionResult MovimentarBracoEsquerdoPulso([FromServices] DataContext context, int idRobo, int proximoMovimentoId)
        {
            try
            {
                var roboDB = context.Robo.Where(x => x.RoboId == idRobo).FirstOrDefault();
                if (roboDB == null)
                    return NotFound("Robo não encontrado");

                var movimento = context.BracoPulsoMovimento.Where(i => i.BracoPulsoMovimentoId == proximoMovimentoId).FirstOrDefault();
                if (movimento == null)
                    return NotFound("Movimento não encontrado");

                Utilitario utilitario = new Utilitario();

                if (!utilitario.VerificarProximoMovimento(proximoMovimentoId, roboDB.movimentoBracoPulsoEsquerdoId))
                    return BadRequest("Movimento não permitido.");
                else if (!utilitario.VerificarPossibilidadeMovimentacaoPulso(roboDB.movimentoBracoCotoveloEsquerdoId))
                    return BadRequest("Movimento não permitido.");
                else
                {
                    roboDB.movimentoBracoPulsoEsquerdoId = proximoMovimentoId;

                    context.Robo.Update(roboDB);
                    context.SaveChanges();

                    return StatusCode(StatusCodes.Status200OK);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Não foi possível executar a ação: " + ex.InnerException);
            }
        }
    }
}
