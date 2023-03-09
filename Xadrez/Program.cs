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

            try
            {
                //Posiciona Peças para teste
                tabuleiro.InserirPeca(new Posicao(0, 0), new Torre(Cor.Branco));
                tabuleiro.InserirPeca(new Posicao(1, 1), new Rei(Cor.Verde));
                tabuleiro.InserirPeca(new Posicao(2, 7), new Dama(Cor.Vermelho));
                tabuleiro.InserirPeca(new Posicao(2, 7), new Dama(Cor.Branco));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroExceptions e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro não tratado: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
