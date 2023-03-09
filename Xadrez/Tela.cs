using System;
using Xadrez.JTabuleiro;

namespace Xadrez
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for(int y = 0; y < tabuleiro.GetCasasPorLinhas; y++)
            {
                for (int x = 0; x < tabuleiro.GetCasasPorColunas; x++)
                {
                    //Verifica se existe uma peça no x,y
                    if (tabuleiro.Peca(x, y) != null)
                    {
                        //Define as cores
                        switch (tabuleiro.Peca(x, y).Cor)
                        {
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

                        Console.Write(tabuleiro.Peca(x, y) + " ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
