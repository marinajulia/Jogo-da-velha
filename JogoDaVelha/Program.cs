using JogoDaVelha.Classes;
using System;

namespace JogoDaVelha {

    class Program {
        static void Main(string[] args) {
            var functions = new Functions();
            int jogada;
            string jogadaDaVez = "", vencedor = "";
            double soma = 0, somaDiagonalPrincipal = 0, somaDiagonalSecundaria = 0;


            string[,] matriz = new string[3, 3];
            double[,] matrizNumerica = new double[3, 3];

            Matrizes ConverterJogada(int Jogada) {

                if (Jogada == 1) {
                    if (matriz[0, 0] == null) {
                        matriz[0, 0] = jogadaDaVez;
                        if (jogadaDaVez == "x") {
                            matrizNumerica[0, 0] = 1;
                        }
                        else {
                            matrizNumerica[0, 0] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();

                        //preciso retornar para fazer a jogada - talvez um while?
                    }

                }
                else if (Jogada == 2) {
                    if (matriz[0, 1] == null) {
                        matriz[0, 1] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[0, 1] = 1;
                        }
                        else {
                            matrizNumerica[0, 1] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();
                    }

                }
                else if (Jogada == 3) {
                    if (matriz[0, 2] == null) {
                        matriz[0, 2] = jogadaDaVez;
                        if (jogadaDaVez == "x") {
                            matrizNumerica[0, 2] = 1;
                        }
                        else {
                            matrizNumerica[0, 2] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();
                    }

                }
                else if (Jogada == 4) {
                    if (matriz[1, 0] == null) {
                        matriz[1, 0] = jogadaDaVez;
                        if (jogadaDaVez == "x") {
                            matrizNumerica[1, 0] = 1;
                        }
                        else {
                            matrizNumerica[1, 0] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();
                    }

                }
                else if (Jogada == 5) {
                    if (matriz[1, 1] == null) {
                        matriz[1, 1] = jogadaDaVez;
                        if (jogadaDaVez == "x") {
                            matrizNumerica[1, 1] = 1;
                        }
                        else {
                            matrizNumerica[1, 1] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();
                    }

                }
                else if (Jogada == 6) {
                    if (matriz[1, 2] == null) {
                        matriz[1, 2] = jogadaDaVez;
                        if (jogadaDaVez == "x") {
                            matrizNumerica[1, 2] = 1;
                        }
                        else {
                            matrizNumerica[1, 2] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();
                    }

                }
                else if (Jogada == 7) {
                    if (matriz[2, 0] == null) {
                        matriz[2, 0] = jogadaDaVez;
                        if (jogadaDaVez == "x") {
                            matrizNumerica[2, 0] = 1;
                        }
                        else {
                            matrizNumerica[2, 0] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();
                    }

                }
                else if (Jogada == 8) {
                    if (matriz[2, 1] == null) {
                        matriz[2, 1] = jogadaDaVez;
                        if (jogadaDaVez == "x") {
                            matrizNumerica[2, 1] = 1;
                        }
                        else {
                            matrizNumerica[2, 1] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();
                    }

                }
                else if (Jogada == 9) {
                    if (matriz[2, 2] == null) {
                        matriz[2, 2] = jogadaDaVez;
                        if (jogadaDaVez == "x") {
                            matrizNumerica[2, 2] = 1;
                        }
                        else {
                            matrizNumerica[2, 2] = -1;
                        }
                    }
                    else {
                        functions.MensagemErro();
                    }

                }
                else {
                    Console.WriteLine("Jogada inválida");
                }
                return new Matrizes();
            }




            var obtemInformacoes = functions.Informacoes();
            double retornoDaJogada = functions.EscolhaDoIcone(obtemInformacoes);
            for (
                int i = 0; i < 9; i++) {

                if (retornoDaJogada == 1) {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'X'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "x";
                    ConverterJogada(jogada);
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
                    ConverterJogada(jogada);
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

            }
            double[] somaColuna = new double[matrizNumerica.Length];
            void VerificarVencedor() {
                for (int l = 0; l < 3; l++) {

                    for (int j = 0; j < 3; j++) {
                        soma += matrizNumerica[l, j];
                        if (soma == 3) {
                            Console.WriteLine("Vencedor é x");
                        }
                        else if (soma == -3) {
                            Console.WriteLine("Vencedor é o");
                        }
                        //verifica coluna
                        somaColuna[j] += matrizNumerica[l, j];

                        for (int x = 0; x < somaColuna.Length; x++) {

                            if (somaColuna[x] == 3) {
                                vencedor = "x";

                            }
                            else if (somaColuna[x] == -3) {
                                vencedor = "o";

                            }
                        }
                        //verifica a soma da diagonal principal
                        if (l == j) {
                            somaDiagonalPrincipal += matrizNumerica[l, j];
                            if (somaDiagonalPrincipal == 3) {
                                vencedor = "x";

                            }
                            else if (somaDiagonalPrincipal == -3) {
                                vencedor = "o";

                            }
                        }

                        if (l + j == 2) {
                            somaDiagonalSecundaria += matrizNumerica[l, j];
                            if (somaDiagonalSecundaria == 3) {
                                vencedor = "x";

                            }
                            else if (somaDiagonalSecundaria == -3) {
                                vencedor = "o";

                            }
                        }
                    }
                }

            }
        }
    }
}
