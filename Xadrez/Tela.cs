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
                        Console.Write(tabuleiro.Peca(x, y) + ".");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }
        }
    }
}
