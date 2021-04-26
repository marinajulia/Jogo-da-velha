using System;

namespace JogoDaVelha {
    class Program {

        static void Main(string[] args) {

            int jogador = 1;
            int jogada;

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
            string escolhaIcone = Console.ReadLine();

            if (escolhaIcone == "x" || escolhaIcone == "X") {
                Console.WriteLine("O outro jogador será 'O'");
                jogador = 1;
            } else if (escolhaIcone == "o" || escolhaIcone == "O") {
                Console.WriteLine("O outro jogador será o 'X'");
                jogador = -1;
            }

            string[,] matriz = new string[3, 3];
            
            for (int i = 0; i < 9; i++) {

                Console.WriteLine("Jogador faça sua jogada:");
                jogada = Convert.ToInt32(Console.ReadLine());
                var teste = ConverterJogada(jogada);

            }


        }
    }
}