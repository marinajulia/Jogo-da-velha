using System;

namespace JogoDaVelha {

    class Program {


        static void Main(string[] args) {

            int jogada;
            double classificacaoJogada = 0;
            string escolhaIconeDoJogador;
            string jogadaDaVez = "";


            Console.WriteLine("__" + "|" + "__" + "|" + "__");
            Console.WriteLine("__" + "|" + "__" + "|" + "__" + "  * *Jogo da velha * *");
            Console.WriteLine("  " + "|" + "  " + "|" + "\n");
            Console.WriteLine(">> A primeira jogada será do jogador 'X'");
            Console.WriteLine("Posições possíveis: 1|2|3");
            Console.WriteLine("                    4|5|6");
            Console.WriteLine("                    7|8|9\n");
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("**Vamos jogar!**\n");


            Console.WriteLine("Escolha seu ícone:(X/O)");
            escolhaIconeDoJogador = Console.ReadLine();


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



            string[,] ConverterJogada(int Jogada) {
                string[,] matriz = new string[3, 3];


                if (Jogada == 1) {
                    matriz[0, 0] = jogadaDaVez;
                }
                else if (Jogada == 2) {
                    matriz[0, 1] = jogadaDaVez;
                }
                else if (Jogada == 3) {
                    matriz[0, 2] = jogadaDaVez;
                }
                else if (Jogada == 4) {
                    matriz[1, 0] = jogadaDaVez;
                }
                else if (Jogada == 5) {
                    matriz[1, 1] = jogadaDaVez;
                }
                else if (Jogada == 6) {
                    matriz[1, 2] = jogadaDaVez;
                }
                else if (Jogada == 7) {
                    matriz[2, 0] = jogadaDaVez;
                }
                else if (Jogada == 8) {
                    matriz[2, 1] = jogadaDaVez;
                }
                else if (Jogada == 9) {
                    matriz[2, 2] = jogadaDaVez;
                }
                else {
                    Console.WriteLine("Jogada inválida");
                }
                return matriz;
            }



            for (
                int i = 0; i < 9; i++) {
                double retornoDaJogada = EscolhaDoIcone(escolhaIconeDoJogador);


                if (retornoDaJogada == 1) {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'X'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "X";
                    ConverterJogada(jogada);
                    retornoDaJogada = -1;
                }
                if (retornoDaJogada == -1) {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Faça a jogada do 'O'");
                    jogada = Convert.ToInt32(Console.ReadLine());
                    jogadaDaVez = "O";
                    ConverterJogada(jogada);
                    retornoDaJogada = 1;   
                }


            }


        }
    }
}
