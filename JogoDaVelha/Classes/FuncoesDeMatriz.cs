using System;
using System.Collections.Generic;
using System.Text;
using JogoDaVelha.Classes;

namespace JogoDaVelha.Classes {
    public class FuncoesDeMatriz {
   
       public bool ConverterJogada(int Jogada, Matrizes matrizes, string jogadaDaVez) {
            var functions = new Functions();
           bool coordenada;



            if (Jogada == 1) {
                if (matrizes.matriz[0, 0] == null) {
                    matrizes.matriz[0, 0] = jogadaDaVez;
                    if (jogadaDaVez == "x") {
                        matrizes.matrizNumerica[0, 0] = 1;
                    
                    }
                    else {
                        matrizes.matrizNumerica[0, 0] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;

                    //preciso retornar para fazer a jogada - talvez um while?
                }

            }
            else if (Jogada == 2) {
                if (matrizes.matriz[0, 1] == null) {
                    matrizes.matriz[0, 1] = jogadaDaVez;
                    if (jogadaDaVez == "x" || jogadaDaVez == "X") {
                        matrizes.matrizNumerica[0, 1] = 1;
                    }
                    else {
                        matrizes.matrizNumerica[0, 1] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;
                }

            }
            else if (Jogada == 3) {
                if (matrizes.matriz[0, 2] == null) {
                    matrizes.matriz[0, 2] = jogadaDaVez;
                    if (jogadaDaVez == "x") {
                        matrizes.matrizNumerica[0, 2] = 1;
                    }
                    else {
                        matrizes.matrizNumerica[0, 2] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;
                }

            }
            else if (Jogada == 4) {
                if (matrizes.matriz[1, 0] == null) {
                    matrizes.matriz[1, 0] = jogadaDaVez;
                    if (jogadaDaVez == "x") {
                        matrizes.matrizNumerica[1, 0] = 1;
                    }
                    else {
                        matrizes.matrizNumerica[1, 0] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;
                }

            }
            else if (Jogada == 5) {
                if (matrizes.matriz[1, 1] == null) {
                    matrizes.matriz[1, 1] = jogadaDaVez;
                    if (jogadaDaVez == "x") {
                        matrizes.matrizNumerica[1, 1] = 1;
                    }
                    else {
                        matrizes.matrizNumerica[1, 1] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;
                }

            }
            else if (Jogada == 6) {
                if (matrizes.matriz[1, 2] == null) {
                    matrizes.matriz[1, 2] = jogadaDaVez;
                    if (jogadaDaVez == "x") {
                        matrizes.matrizNumerica[1, 2] = 1;
                    }
                    else {
                        matrizes.matrizNumerica[1, 2] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;
                }

            }
            else if (Jogada == 7) {
                if (matrizes.matriz[2, 0] == null) {
                    matrizes.matriz[2, 0] = jogadaDaVez;
                    if (jogadaDaVez == "x") {
                        matrizes.matrizNumerica[2, 0] = 1;
                    }
                    else {
                        matrizes.matrizNumerica[2, 0] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;
                }

            }
            else if (Jogada == 8) {
                if (matrizes.matriz[2, 1] == null) {
                    matrizes.matriz[2, 1] = jogadaDaVez;
                    if (jogadaDaVez == "x") {
                        matrizes.matrizNumerica[2, 1] = 1;
                    }
                    else {
                        matrizes.matrizNumerica[2, 1] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;
                }

            }
            else if (Jogada == 9) {
                if (matrizes.matriz[2, 2] == null) {
                    matrizes.matriz[2, 2] = jogadaDaVez;
                    if (jogadaDaVez == "x") {
                        matrizes.matrizNumerica[2, 2] = 1;
                    }
                    else {
                        matrizes.matrizNumerica[2, 2] = -1;
                    }
                    return true;
                }
                else {
                    functions.MensagemErro();
                    return false;
                }

            }
            else {
                Console.WriteLine("Jogada inválida");
                return false;
            }
         
        }
    }
}
