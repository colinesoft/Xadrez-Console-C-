using System;
using Xadrez.JTabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro();
            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}
