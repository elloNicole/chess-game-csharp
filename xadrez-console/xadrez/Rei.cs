using tabuleiro;

namespace xadrez
{
    internal class Rei : Peca 
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab) {

        }
        public override string ToString()
        {
            return "R";
        }


        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }


        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //rei acima: 1 linha a menos e mesma coluna
            pos.definirValores(posicao.linha - 1, posicao.coluna);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //rei nordeste: linha -1 e coluna +1
            pos.definirValores(posicao.linha - 1, posicao.coluna +1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //rei direita: linha  e coluna +1
            pos.definirValores(posicao.linha, posicao.coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //rei sudeste: linha +1  e coluna +1
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            //rei baixo: linha +1  e coluna igual
            pos.definirValores(posicao.linha + 1, posicao.coluna);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            //rei sudoeste: linha +1  e coluna -1
            pos.definirValores(posicao.linha + 1, posicao.coluna -1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //rei esquerda: linha e coluna -1
            pos.definirValores(posicao.linha, posicao.coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //rei nordeste: linha  - 1 e coluna -1
            pos.definirValores(posicao.linha -1 , posicao.coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }

    }
}