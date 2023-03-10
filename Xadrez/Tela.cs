using System;
using Xadrez.JTabuleiro;

namespace Xadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            Console.Clear();
            string legenda = "  ";
            for(int y = 0; y < tabuleiro.ObterTamanhoLateralDoTabuleiro; y++)
            {
                //Impressão do número das linhas do maior para o menor
                Console.Write(tabuleiro.ObterTamanhoLateralDoTabuleiro - y + " ");

                for (int x = 0; x < tabuleiro.ObterTamanhoLateralDoTabuleiro; x++)
                {
                    if(y == 0)
                    {
                        legenda += $" {(char)('A' + x)} ";
                    }

                    //Verifica se existe uma peça no x,y
                    if (tabuleiro.Peca(x, y) != null)
                    {
                        Console.Write(" ");
                        ImprimirPeca(tabuleiro.Peca(x, y));
                        Console.Write(" ");
                    }
                    else
                        Console.Write(" - ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(legenda);
        }

        private static void ImprimirPeca(Peca peca)
        {
            ConsoleColor corAtual = Console.ForegroundColor;
            //Define as cores
            switch (peca.Cor)
            {
                case Cor.Amarelo:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Cor.Preto:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Cor.Azul:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Cor.Branco:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Cor.Cinza:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Cor.Verde:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Cor.Vermelho:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.Write(peca.ToString());
            Console.ForegroundColor = corAtual;
        }

        public static Posicao ObterPosicao()
        {
            var obtido = Console.ReadLine();
            return new Posicao(obtido[0], int.Parse(obtido[1] + ""));
        }
    }
}
