using tabuleiro;
using xadrez;

namespace Xadrez_console {
    class Program {


        private static void Main(string[] args) {
            try {

                PartidaDeXadrez partida = new();

                while (!partida.Terminada) {
                    try {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);
                        Console.WriteLine();

                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);

                        if (partida.Promocao) {
                            string s;
                            do {
                                Console.WriteLine("Peão promovido! Escolha um número:");
                                Console.WriteLine("1 - Dama");
                                Console.WriteLine("2 - Bispo");
                                Console.WriteLine("3 - Torre");
                                Console.WriteLine("4 - Cavalo");

                                 s = Console.ReadLine();
                            } while (int.Parse(s) < 0 && int.Parse(s) > 4);
                                partida.EscolhaPromocao(s);
                            
                        }
                    }
                    catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                    catch (Exception e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }


                }

                Console.Clear();
                Tela.ImprimirPartida(partida);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}