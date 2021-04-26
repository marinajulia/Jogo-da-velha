using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha {
    class ConverterJogada {
        public int jogada;
        public int[] posicoesMatriz = new int[2];
       

       public int numerosMatriz(jogada) {
            if (jogada == 1) {
                posicoesMatriz[0] = 0;
                posicoesMatriz[1] = 0;
            } else if (jogada == 2) {
                posicoesMatriz[0] = 0;
                posicoesMatriz[1] = 1;
            } else if (jogada == 3) {
                posicoesMatriz[0] = 0;
                posicoesMatriz[1] = 2;
            } else if (jogada == 4) {
                posicoesMatriz[0] = 1;
                posicoesMatriz[1] = 0;
            } else if (jogada == 5) {
                posicoesMatriz[0] = 1;
                posicoesMatriz[1] = 1;
            } else if (jogada == 6) {
                posicoesMatriz[0] = 1;
                posicoesMatriz[1] = 2;
            } else if (jogada == 7) {
                posicoesMatriz[0] = 2;
                posicoesMatriz[1] = 0;
            } else if (jogada == 8) {
                posicoesMatriz[0] = 2;
                posicoesMatriz[1] = 1;
            } else if (jogada == 9) {
                posicoesMatriz[0] = 2;
                posicoesMatriz[1] = 2;
            } else {
                Console.WriteLine("Jogada inválida");
            }
            return posicoesMatriz[0];

        }
    }
}
