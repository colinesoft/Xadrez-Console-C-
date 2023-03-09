using System;
using Xadrez.JTabuleiro;
using Xadrez.JXadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro();

            //Posiciona Peças para teste
            tabuleiro.InserirPeca(new Posicao(0, 0), new Torre(Cor.Branco));
            tabuleiro.InserirPeca(new Posicao(1, 1), new Rei(Cor.Verde));
            tabuleiro.InserirPeca(new Posicao(2, 2), new Dama(Cor.Vermelho));

            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}
