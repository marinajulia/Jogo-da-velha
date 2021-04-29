using JogoDaVelha.Classes;
using System;

namespace JogoDaVelha {

    class Program {
        static void Main(string[] args) {
            var functions = new Functions();
            var funcoesMatriz = new FuncoesDeMatriz();
            int jogada;
            string jogadaDaVez = "", vencedor = "nenhum";
            double soma = 0;
            var matriz = new string[3, 3];
            var matrizNumerica = new double[3, 3];

            var obtemInformacoes = functions.Informacoes();
            double retornoDaJogada = functions.EscolhaDoIcone(obtemInformacoes);

            void VerificarVencedor() {
               
                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {

                        soma += matrizNumerica[i, j];
                        if (soma == 3) {
                            vencedor = "x";

                        }
                        else if (soma == -3) {
                            vencedor = "o";

                        }

                    }
                    soma = 0;
                }
                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {
                        soma += matrizNumerica[j, i];
                        if (soma == 3) {
                            vencedor = "x";

                        }
                        else if (soma == -3) {
                            vencedor = "o";

                        }
                    }
                    soma = 0;
                }
                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {

                        if (i == j) {
                            soma += matrizNumerica[i, j];
                            if (soma == 3) {
                                vencedor = "x";

                            }
                            else if (soma == -3) {
                                vencedor = "o";

                            }
                        }
                    }
                    
                }

                Console.WriteLine("O vencedor é: " + vencedor);
            }


            for (
                int i = 0; i < 9; i++) {

                if (retornoDaJogada == 1) {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'X'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "x";
                    Matrizes matrizCompleta = new Matrizes();
                    matrizCompleta.matriz = matriz;
                    matrizCompleta.matrizNumerica = matrizNumerica;
                    var passarParaCoordenada = funcoesMatriz.ConverterJogada(jogada, matrizCompleta, jogadaDaVez);
                    retornoDaJogada = -1;
                    string imprimeJogada = "";

                    for (int l = 0; l < 3; l++) {

                        for (int j = 0; j < 3; j++) {
                            imprimeJogada += "|" + matriz[l, j] + "|";

                        }

                        Console.WriteLine(imprimeJogada);


                        imprimeJogada = "";

                    }
                }
                else if (retornoDaJogada == -1) {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'O'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "o";
                    Matrizes matrizCompleta = new Matrizes();
                    matrizCompleta.matriz = matriz;
                    matrizCompleta.matrizNumerica = matrizNumerica;
                    var passarParaCoordenada = funcoesMatriz.ConverterJogada(jogada, matrizCompleta, jogadaDaVez);
                    retornoDaJogada = 1;
                    string imprimeJogada = "";

                    for (int l = 0; l < 3; l++) {

                        for (int j = 0; j < 3; j++) {
                            imprimeJogada += "|" + matriz[l, j] + "|";
                        }
                        Console.WriteLine(imprimeJogada);

                        imprimeJogada = "";

                    }
                }
                VerificarVencedor();

            }


        }
    }
}
