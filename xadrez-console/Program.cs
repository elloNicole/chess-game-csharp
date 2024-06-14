using System;
using tabuleiro;
using xadrez;

namespace xadrez_console 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);


                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
                Tela.imprimirTabuleiro(partida.tab);

            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }


       
    }
}