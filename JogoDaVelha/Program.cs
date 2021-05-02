﻿using JogoDaVelha.Classes;
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

            var obtemInformacoes = functions.Informacoes();
            double retornoDaJogada = functions.EscolhaDoIcone(obtemInformacoes);

            void VerificarVencedor() {

                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {

                        soma += matrizNumerica[i, j];
                        if (soma == 3) {
                            vencedor = "x";
                            functions.MensagemSucesso(vencedor);
                            Environment.Exit(0);

                        }
                        else if (soma == -3) {
                            vencedor = "o";
                            functions.MensagemSucesso(vencedor);
                            Environment.Exit(0);
                        }

                    }
                    soma = 0;
                    
                }

                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {
                        soma += matrizNumerica[j, i];
                        if (soma == 3) {
                            vencedor = "x";
                            functions.MensagemSucesso(vencedor);
                            Environment.Exit(0);

                        }
                        else if (soma == -3) {
                            vencedor = "o";
                            functions.MensagemSucesso(vencedor);
                            Environment.Exit(0);

                        }
                    }
                    soma = 0;

                }


                for (int i = 0; i < 3; i++) {

                    for (int j = 0; j < 3; j++) {
                        if (i + j == 2) {
                            soma += matrizNumerica[i, j];
                            if (soma == 3) {
                                vencedor = "x";
                                functions.MensagemSucesso(vencedor);
                                Environment.Exit(0);

                            }
                            else if (soma == -3) {
                                vencedor = "o";
                                functions.MensagemSucesso(vencedor);
                                Environment.Exit(0);
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
                                vencedor = "x";
                                functions.MensagemSucesso(vencedor);
                                Environment.Exit(0);
                                
                            }
                            else if (soma == -3) {
                                vencedor = "o";
                                functions.MensagemSucesso(vencedor);
                                Environment.Exit(0);
                            }

                        }

                    }

                }

                soma = 0;
              

            }

            Matrizes matrizCompleta = new Matrizes();
            matrizCompleta.matriz = matriz;
            matrizCompleta.matrizNumerica = matrizNumerica;

            while (vencedor != null) {

                if (retornoDaJogada == 1) {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'X'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "x";
                   
                   bool jogadaFeitaComSucesso = funcoesMatriz.ConverterJogada(jogada, matrizCompleta, jogadaDaVez);
                    if (jogadaFeitaComSucesso) {
                        retornoDaJogada = -1;
                    }
                    string imprimeJogada = "";

                    for (int l = 0; l < 3; l++) {

                        for (int j = 0; j < 3; j++) {

                            if (matriz[l, j] == null) {
                                imprimeJogada += "|" + "-" + "|";
                            }
                            else {
                                imprimeJogada += "|" + matriz[l, j] + "|";
                            }


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

                    bool jogadaFeitaComSucesso = funcoesMatriz.ConverterJogada(jogada, matrizCompleta, jogadaDaVez);
                    if (jogadaFeitaComSucesso) {
                        retornoDaJogada = 1;
                    }

                    string imprimeJogada = "";

                    for (int l = 0; l < 3; l++) {

                        for (int j = 0; j < 3; j++) {

                            if (matriz[l, j] == null) {
                                imprimeJogada += "|" + "-" + "|";
                            }
                            else {
                                imprimeJogada += "|" + matriz[l, j] + "|";
                            }
                        }
                        Console.WriteLine(imprimeJogada);

                        imprimeJogada = "";

                    }
                }
                VerificarVencedor();

            }

          
                functions.MensagemEmpate();
            
        }
    }
}
