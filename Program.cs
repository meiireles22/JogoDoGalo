using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDoGalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            string[] tabuleiro = new string[9];
            bool tabuleironaocheio = true;
            bool ganhou = false;
            int jogada = 1;
            string numescolhido = "";
            string sinal = "";
            for(int i = 0; i < 9; i++)
            {
                tabuleiro[i] ="" +(i + 1);
            }

            Console.WriteLine("Jogador numero 1 diga o seu nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Jogador numero 2 o seu nome: ");
            nome2 = Console.ReadLine();

            do
            {
                //Console.Clear();
                //mostrar tabuleiro
                Console.WriteLine(" " + tabuleiro[0] + " | " + tabuleiro[1] + " | " + tabuleiro[2] + " ");
                Console.WriteLine("---------------");
                Console.WriteLine(" " + tabuleiro[3] + " | " + tabuleiro[4] + " | " + tabuleiro[5] + " ");
                Console.WriteLine("---------------");
                Console.WriteLine(" " + tabuleiro[6] + " | " + tabuleiro[7] + " | " + tabuleiro[8] + " ");
                //1- verificar quem joga e pedir para jogar
                if (jogada == 1)
                {
                    //jogador #1
                    Console.WriteLine("Qual o número onde pretende jogar" + nome1);
                    sinal = "X";
                }
                else
                {
                    //jogador #2
                    Console.WriteLine("Qual o número onde pretende jogar " + nome2);
                    sinal = "O";
                }

                numescolhido = Console.ReadLine();

                if (tabuleiro[Convert.ToInt32(numescolhido) - 1].ToString() != numescolhido)
                {
                    //a posição está ocupada
                    Console.WriteLine("A posição " + numescolhido + " já está preenchida");
                }
                else
                {
                    Console.WriteLine("teste");
                    //Tabuleiro[posição está livre]
                    tabuleiro[(Convert.ToInt32(numescolhido) - 1)] = sinal;

                    // verificar se ganhou ou perdeu
                    ganhou = false;
                    if (tabuleiro[0] == tabuleiro[1] && tabuleiro[1] == tabuleiro[2])
                    {
                        ganhou = true;
                    }
                    else if (tabuleiro[3] == tabuleiro[4] && tabuleiro[4] == tabuleiro[5])
                    {
                        ganhou = true;
                    }
                    else if (tabuleiro[6] == tabuleiro[7] && tabuleiro[7] == tabuleiro[8])
                    {
                        ganhou = true;
                    }
                    else if (tabuleiro[0] == tabuleiro[3] && tabuleiro[3] == tabuleiro[6])
                    {
                        ganhou = true;
                    }
                    else if (tabuleiro[1] == tabuleiro[4] && tabuleiro[4] == tabuleiro[7])
                    {
                        ganhou = true;
                    }
                    else if (tabuleiro[2] == tabuleiro[5] && tabuleiro[5] == tabuleiro[8])
                    {
                        ganhou = true;
                    }
                    else if (tabuleiro[0] == tabuleiro[4] && tabuleiro[4] == tabuleiro[8])
                    {
                        ganhou = true;
                    }
                    else if (tabuleiro[2] == tabuleiro[4] && tabuleiro[4] == tabuleiro[6])
                    {
                        ganhou = true;
                    }

                }
                // verificar se nao ganhou se está cheio ou vazio
                tabuleironaocheio = false;
                for (int i = 0; i < 9; i++)
                {
                    if (tabuleiro[i] != Convert.ToString(i))
                    {
                        tabuleironaocheio = true;
                        break;
                    }
                }
                if (!ganhou)
                {
                    if (jogada == 1)
                    {
                        jogada = 2;
                    }
                    else
                    {
                        jogada = 1;
                    }
                }
            } while (tabuleironaocheio & !ganhou);

            if(ganhou)
            {
                if (jogada == 1)
                {
                    Console.WriteLine("Quem ganhou foi o jogador: " + nome1);
                }
                else
                {
                    Console.WriteLine("Quem ganhou foi o jogador : " + nome2);
                }

            } else if (!tabuleironaocheio)
            {
                Console.WriteLine("O jogo chegou ao fim sem vencedor ");
            }

            //espera para terminar jogo
            Console.ReadLine();
        }
    }
}
