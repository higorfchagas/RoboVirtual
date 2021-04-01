namespace ProjetoRoboNddTech.Services
{
    public class Utilitario
    {
        public bool VerificarProximoMovimento(int? movimentoProximo, int? movimentoAnterior)
        {
            if ((movimentoAnterior == movimentoProximo + 1 || movimentoAnterior == movimentoProximo - 1) && movimentoProximo != movimentoAnterior )
            {
                return true;
            }

            return false;
        }

        public bool VerificarPossibilidadeRotacaoCabeca(int? estadoInclinacaoAtual)
        {
            if (estadoInclinacaoAtual == 3)
                return false;
            else
                return true; 
        }

        public bool VerificarPossibilidadeMovimentacaoPulso(int? estadoInclinacaoCotovelo)
        {
            if (estadoInclinacaoCotovelo == 4)
                return true;
            else
                return false; 
        }
    }
}