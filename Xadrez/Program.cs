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
                Partida partida = new Partida();

                while (!partida.Encerrada)
                {
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.ObterPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.ObterPosicao();

                    partida.MovimentaPeca(origem, destino);
                }


                Console.ReadKey();
                Tela.ImprimirTabuleiro(partida.Tabuleiro);
                Console.ReadKey();
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
