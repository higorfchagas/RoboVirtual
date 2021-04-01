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
    [Route("MovimentarCabeca")]
    public class CabecaController : ControllerBase
    {
        [HttpPut]
        [Route("Rotacionar/{idRobo}/{proximoMovimentoId}")]
        public ActionResult RotacionarCabeca([FromServices] DataContext context, int idRobo, int proximoMovimentoId)
        {
            try
            {
                var roboDB = context.Robo.Where(x => x.RoboId == idRobo).FirstOrDefault();

                Utilitario utilitario = new Utilitario();

                if (!utilitario.VerificarPossibilidadeRotacaoCabeca(roboDB.movimentoCabecaInclinacaoId))
                    return BadRequest("Movimento não permitido.");
                else if (!utilitario.VerificarProximoMovimento(proximoMovimentoId, roboDB.movimentoCabecaRotacaoId))
                    return BadRequest("Movimento não permitido.");
                else
                {
                    roboDB.movimentoCabecaRotacaoId = proximoMovimentoId;
                    
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
        [Route("Inclinar/{idRobo}/{proximoMovimentoId}")]
        public ActionResult InclinarCabeca([FromServices] DataContext context, int idRobo, int proximoMovimentoId)
        {
            try
            {
                var roboDB = context.Robo.Where(x => x.RoboId == idRobo).FirstOrDefault();

                Utilitario utilitario = new Utilitario();

                if (!utilitario.VerificarProximoMovimento(proximoMovimentoId, roboDB.movimentoCabecaInclinacaoId))
                    return BadRequest("Movimento não permitido.");
                else
                {
                    roboDB.movimentoCabecaInclinacaoId = proximoMovimentoId;

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
