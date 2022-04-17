using System;

namespace EPCSemMediator
{
    internal class PosGraduacao
    {
        public static void chamarPosGraduacao(Atividade atividade)
        {
            
        }

        internal void chamarPontuacao()
        {
            Pontuacao.chamarPontuacao(this);
        }
    }
}