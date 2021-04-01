using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRoboNddTech.Models
{
    public class CabecaRotacaoMovimento
    {
        [Key]
        public int CabecaRotacaoMovimentoId { get; set; }
        public string CabecaRotacaoMovimentoDescricao { get; set; }
    }
}
