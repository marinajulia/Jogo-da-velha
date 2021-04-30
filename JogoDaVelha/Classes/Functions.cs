using System;
using JogoDaVelha.Classes;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha.Classes {
    public class Functions {

        public string Informacoes() {
            string iconeEscolhido ="";
            Console.WriteLine("__" + "|" + "__" + "|" + "__");
            Console.WriteLine("__" + "|" + "__" + "|" + "__" + "  * *Jogo da velha * *");
            Console.WriteLine("  " + "|" + "  " + "|" + "\n");
            Console.WriteLine(">> A primeira jogada será do jogador que escolher o ícone primeiro");
            Console.WriteLine("Posições possíveis: 1|2|3");
            Console.WriteLine("                    4|5|6");
            Console.WriteLine("                    7|8|9\n");
            Console.WriteLine("-------------------------------------------------------------------\n");
            Console.WriteLine("**Vamos jogar!**\n");
            Console.WriteLine("Escolha seu ícone:(X/O)");
            iconeEscolhido = Console.ReadLine();
            return iconeEscolhido;
        }


        public double EscolhaDoIcone(string escolhaIcone) {
            double classificacaoJogada = 0;

            if (escolhaIcone == "x" || escolhaIcone == "X") {
                Console.WriteLine("O outro jogador será 'O'\n");
                classificacaoJogada = 1;

            }
            else if (escolhaIcone == "o" || escolhaIcone == "O") {
                Console.WriteLine("O outro jogador será o 'X'");
                classificacaoJogada = -1;
            }
            else {
                Console.WriteLine("Caracter inválido");
            }

            return classificacaoJogada;
        }
        public void MensagemErro() {
            Console.WriteLine("A casa já tem uma jogada");
        }

        public void MensagemSucesso(string vencedor) {
            Console.WriteLine("O vencedor é: " + vencedor);
        }
        public void MensagemEmpate() {
            Console.WriteLine("Houve um empate!");
        }


        void VerificarVencedor() {
            double soma = 0;
            string vencedor = "";
            for (int i = 0; i < 3; i++) {

                for (int j = 0; j < 3; j++) {

                    soma += matrizNumerica[i, j];
                    if (soma == 3) {
                        vencedor = "x";
                        MensagemSucesso(vencedor);
                        Environment.Exit(0);

                    }
                    else if (soma == -3) {
                        vencedor = "o";
                        MensagemSucesso(vencedor);
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
                        MensagemSucesso(vencedor);
                        Environment.Exit(0);

                    }
                    else if (soma == -3) {
                        vencedor = "o";
                        MensagemSucesso(vencedor);
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
                            MensagemSucesso(vencedor);
                            Environment.Exit(0);

                        }
                        else if (soma == -3) {
                            vencedor = "o";
                            MensagemSucesso(vencedor);
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
                            MensagemSucesso(vencedor);
                            Environment.Exit(0);

                        }
                        else if (soma == -3) {
                            vencedor = "o";
                            MensagemSucesso(vencedor);
                            Environment.Exit(0);
                        }

                    }

                }

            }

            soma = 0;


        }


        void aplicar() {
            var matriz = new string[3, 3];
            var matrizNumerica = new double[3, 3];
            string jogadaDaVez = "";
            var funcoesMatriz = new FuncoesDeMatriz();
            int jogada;
            double retornoDaJogada = EscolhaDoIcone(Informacoes());
            for (int i = 0; i < 9; i++) {

                if (retornoDaJogada == 1) {
                    Console.WriteLine("-------------------------------------------------------------------");
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
                    Console.WriteLine("-------------------------------------------------------------------");
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
        }

    }
}
