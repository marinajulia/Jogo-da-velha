using JogoDaVelha.Classes;
using System;

namespace JogoDaVelha {

    class Program {
        static void Main(string[] args) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var functions = new Functions();
            var funcoesMatriz = new FuncoesDeMatriz();
            int jogada;
            string jogadaDaVez = "", vencedor = "nenhum";
            double soma = 0;
            var matriz = new string[3, 3];
            var matrizNumerica = new double[3, 3];
            string resultadoDoJogo = null;

            var obtemInformacoes = functions.Informacoes();
            double retornoDaJogada = functions.EscolhaDoIcone(obtemInformacoes);

            string VerificarVencedor() {

                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {

                        soma += matrizNumerica[i, j];
                        if (soma == 3) {
                            return "x";


                        }
                        else if (soma == -3) {
                            return "o";
                        }

                    }
                    soma = 0;

                }

                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {
                        soma += matrizNumerica[j, i];
                        if (soma == 3) {
                            return "x";

                        }
                        else if (soma == -3) {
                            return "o";

                        }
                    }
                    soma = 0;

                }


                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {
                        if (i + j == 2) {
                            soma += matrizNumerica[i, j];
                            if (soma == 3) {
                                return "x";

                            }
                            else if (soma == -3) {
                                return "o";
                            }
                        }
                    }

                }
                soma = 0;


                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {
                        if (i == j) {
                            soma += matrizNumerica[i, j];
                            if (soma == 3) {
                                return "x";

                            }
                            else if (soma == -3) {
                                return "o";
                            }

                        }

                    }

                }
                soma = 0;

                int qtdCamposPreenchidos = 0;
                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {
                        if (matrizNumerica[i, j] != 0) {
                            qtdCamposPreenchidos++;
                        }

                    }
                }

                if(qtdCamposPreenchidos == 9) {
                    return "VELHA";
                }

                return null;
                

            }

            Matrizes matrizCompleta = new Matrizes();
            matrizCompleta.matriz = matriz;
            matrizCompleta.matrizNumerica = matrizNumerica;




            do {

                if (retornoDaJogada == 1) {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'X'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "x";

                    bool jogadaFeitaComSucesso = funcoesMatriz.ConverterJogada(jogada, matrizCompleta, jogadaDaVez);
                    if (jogadaFeitaComSucesso) {
                        retornoDaJogada = -1;
                    }

                    functions.ImprimirJogada(matriz);

                }
                else if (retornoDaJogada == -1) {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'O'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "o";

                    bool jogadaFeitaComSucesso = funcoesMatriz.ConverterJogada(jogada, matrizCompleta, jogadaDaVez);
                    if (jogadaFeitaComSucesso) {
                        retornoDaJogada = 1;
                    }

                    functions.ImprimirJogada(matriz);

                }
                resultadoDoJogo = VerificarVencedor();
                Console.WriteLine(resultadoDoJogo) ;
            } while (resultadoDoJogo == null);

            if (resultadoDoJogo == "x") {
                functions.MensagemSucesso("x");
            }

            else if (resultadoDoJogo == "o") {
                functions.MensagemSucesso("o");
            } else if(resultadoDoJogo == "VELHA") {
                functions.MensagemEmpate();
            }
        }
    }
}

