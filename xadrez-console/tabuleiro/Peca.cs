﻿namespace tabuleiro
{
    abstract internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }    
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.cor = cor;
            this.tab = tab;
            this.posicao = null;
            this.qteMovimentos = 0;
        }

        public void incrementarQtdMovimentos()
        {
            qteMovimentos++;
        } 

        public void decrementarQtdMovimentos()
        {
            qteMovimentos--;
        } 


        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i <tab.linhas; i++)
            {
                for (int j=0; j < tab.colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();

    }
}
