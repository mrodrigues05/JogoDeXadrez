using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0 ,1));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 2));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 3));

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 1));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 2));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(4, 3));


                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine(); 
        }
    }
}
