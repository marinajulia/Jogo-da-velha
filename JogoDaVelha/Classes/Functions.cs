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

    }
}
