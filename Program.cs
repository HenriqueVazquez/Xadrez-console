using tabuleiro;
using xadrez;

namespace Xadrez_console {
    class Program {


        private static void Main(string[] args) {
            try {

                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, tabuleiro.enums.Cor.Preta), new Posicao(0, 0));

                tab.colocarPeca(new Torre(tab, tabuleiro.enums.Cor.Preta), new Posicao(1, 3));

                tab.colocarPeca(new Rei(tab, tabuleiro.enums.Cor.Preta), new Posicao(0, 7));

                tab.colocarPeca(new Rei(tab, tabuleiro.enums.Cor.Branca), new Posicao(3, 5));

                Tela.imprimirTabuleiro(tab);


                Console.ReadLine();
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}