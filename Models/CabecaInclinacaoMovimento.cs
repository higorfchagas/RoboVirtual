using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRoboNddTech.Models
{
    public class CabecaInclinacaoMovimento
    {
        [Key]
        public int CabecaInclinacaoMovimentoId { get; set; }
        public string CabecaInclinacaoMovimentoDescricao { get; set; }
    }
}
