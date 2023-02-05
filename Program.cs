using tabuleiro;
using xadrez;

namespace Xadrez_console {
    class Program {


        private static void Main(string[] args) {
            try {

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                

                Tela.imprimirTabuleiro(partida.tab);


                Console.ReadLine();
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}