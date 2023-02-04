using tabuleiro;

namespace Xadrez_console {
    class Program {


        private static void Main(string[] args) {
            
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);


            Console.ReadLine();

        }
    }
}