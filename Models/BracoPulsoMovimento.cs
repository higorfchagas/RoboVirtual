using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRoboNddTech.Models
{
    public class BracoPulsoMovimento
    {
        [Key]
        public int BracoPulsoMovimentoId { get; set; }
        public string BracoPulsoMovimentoDescricao { get; set; }
    }
}
