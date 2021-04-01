using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoRoboNddTech.DTO
{
    public class RoboDTO
    
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CabecaRotacao { get; set; }
        public string CabecaInclinacao { get; set; }
        public string BracoDireitoCotovelo { get; set; }
        public string BracoDireitoPulso { get; set; }
        public string BracoEsquerdoCotovelo { get; set; }
        public string BracoEsquerdoPulso { get; set; }

    }
}
