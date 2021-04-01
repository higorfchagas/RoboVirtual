using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRoboNddTech.Models
{
    public class Robo
    {
        [Key]
        public int RoboId { get; set; }
        public string Nome { get; set; }

        //Cabeça rotação
        public int? movimentoCabecaRotacaoId { get; set; }
        public CabecaRotacaoMovimento MovimentoCabecaRotacao { get; set; }

        //Cabeça inclinação
        public int? movimentoCabecaInclinacaoId { get; set; }
        public CabecaInclinacaoMovimento MovimentoCabecaInclinacao { get; set; }

        //Braço cotovelo direito
        public int? movimentoBracoCotoveloDireitoId { get; set; }
        public BracoCotoveloMovimento MovimentoBracoCotoveloDireito { get; set; }

        //Braço pulso direito
        public int? movimentoBracoPulsoDireitoId { get; set; }
        public BracoPulsoMovimento MovimentoBracoPulsoDireito { get; set; }

        //Braço cotovelo esquerdo
        public int? movimentoBracoCotoveloEsquerdoId { get; set; }
        public BracoCotoveloMovimento MovimentoBracoCotoveloEsquerdo { get; set; }

        //Braço pulso esquerdo
        public int? movimentoBracoPulsoEsquerdoId { get; set; }
        public BracoPulsoMovimento MovimentoBracoPulsoEsquerdo { get; set; }
        

    }
}
