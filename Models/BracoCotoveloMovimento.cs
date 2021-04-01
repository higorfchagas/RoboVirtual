using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRoboNddTech.Models
{
    public class BracoCotoveloMovimento
    {
        [Key]
        public int BracoCotoveloMovimentoId { get; set; }
        public string BracoCotoveloMovimentoDescricao { get; set; }
    }
}
