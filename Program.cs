﻿using tabuleiro;
using xadrez;

namespace Xadrez_console {
    class Program {


        private static void Main(string[] args) {
            
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, tabuleiro.enums.Cor.Preta), new Posicao(0, 0));

            tab.colocarPeca(new Torre(tab, tabuleiro.enums.Cor.Preta), new Posicao(1, 3));

            tab.colocarPeca(new Rei(tab, tabuleiro.enums.Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);


            Console.ReadLine();

        }
    }
}