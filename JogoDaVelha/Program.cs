using System;

namespace JogoDaVelha {

    class Program {

        public class matrizTest {
            public string[,] matriz { get; set; }
            public double[,] matrizNumerica { get; set; }
        }
        static void Main(string[] args) {

            int jogada;
            double classificacaoJogada = 0;
            string escolhaIconeDoJogador;
            string jogadaDaVez = "";


            

            Console.WriteLine("__" + "|" + "__" + "|" + "__");
            Console.WriteLine("__" + "|" + "__" + "|" + "__" + "  * *Jogo da velha * *");
            Console.WriteLine("  " + "|" + "  " + "|" + "\n");
            Console.WriteLine(">> A primeira jogada será do jogador que escolher o ícone primeiro");
            Console.WriteLine("Posições possíveis: 1|2|3");
            Console.WriteLine("                    4|5|6");
            Console.WriteLine("                    7|8|9\n");
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("**Vamos jogar!**\n");


            Console.WriteLine("Escolha seu ícone:(X/O)");
            escolhaIconeDoJogador = Console.ReadLine();

            string[,] matriz = new string[3, 3];
            double[,] matrizNumerica = new double[3, 3];

            matrizTest ConverterJogada(int Jogada) {

                if (Jogada == 1) {
                    if (matriz[0, 0] == null) {
                        matriz[0, 0] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[0, 0] = 1;
                        }
                        else {
                            matrizNumerica[0, 0] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else if (Jogada == 2) {
                    if (matriz[0, 1] == null) {
                        matriz[0, 1] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[0, 1] = 1;
                        }
                        else {
                            matrizNumerica[0, 2] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else if (Jogada == 3) {
                    if (matriz[0, 2] == null) {
                        matriz[0, 2] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[0, 2] = 1;
                        }
                        else {
                            matrizNumerica[0, 2] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else if (Jogada == 4) {
                    if (matriz[1, 0] == null) {
                        matriz[1, 0] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[1, 0] = 1;
                        }
                        else {
                            matrizNumerica[1, 0] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else if (Jogada == 5) {
                    if (matriz[1, 1] == null) {
                        matriz[1, 1] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[1, 1] = 1;
                        }
                        else {
                            matrizNumerica[1, 1] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else if (Jogada == 6) {
                    if (matriz[1, 2] == null) {
                        matriz[1, 2] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[1, 2] = 1;
                        }
                        else {
                            matrizNumerica[1, 2] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else if (Jogada == 7) {
                    if (matriz[2, 0] == null) {
                        matriz[2, 0] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[2, 0] = 1;
                        }
                        else {
                            matrizNumerica[2, 0] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else if (Jogada == 8) {
                    if (matriz[2, 1] == null) {
                        matriz[2, 1] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[2, 1] = 1;
                        }
                        else {
                            matrizNumerica[2, 1] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else if (Jogada == 9) {
                    if (matriz[2, 2] == null) {
                        matriz[2, 2] = jogadaDaVez;
                        if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                            matrizNumerica[2, 2] = 1;
                        }
                        else {
                            matrizNumerica[2, 2] = -1;
                        }
                    }
                    else {
                        Console.WriteLine("A casa já tem uma jogada");
                    }

                }
                else {
                    Console.WriteLine("Jogada inválida");
                }
                return new matrizTest();
            }



            double EscolhaDoIcone(string escolhaIcone) {

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

            double retornoDaJogada = EscolhaDoIcone(escolhaIconeDoJogador);


            for (
                int i = 0; i < 9; i++) {

                if (retornoDaJogada == 1) {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'X'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "X";
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
                    jogadaDaVez = "O";
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

            double soma = 0;
            string vencedor = "";


            double[] somaColuna = new double[matrizNumerica.Length];
            void VerificarVencedor() {
                for (int l = 0; l < 3; l++) {

                    for (int j = 0; j < 3; j++) {
                        soma += matrizNumerica[l, j];
                        if (soma == 3) {
                            vencedor = "x";
                        }else if (soma == -3) {
                            vencedor = "o";
                        }
                        somaColuna[j] += matrizNumerica[l, j];
                    }

                }for(int x =0; x <somaColuna.Length; x++) {
                    Console.WriteLine(somaColuna[x] + " ");
                }

            }
        }
    }
}
