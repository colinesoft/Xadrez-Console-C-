using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.JTabuleiro;

namespace Xadrez.JXadrez
{
    public class Partida
    {
        public Tabuleiro Tabuleiro { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool Encerrada { get; private set; }

        public Partida()
        {
            Tabuleiro = new Tabuleiro();
            turno = 1;
            jogadorAtual = Cor.Branco;
            PlotarPecas();
        }
        

        public void MovimentaPeca(Posicao origem, Posicao destino)
        {
            Peca peca = Tabuleiro.RemoverPecaDaPosicao(origem);

            if (peca == null)
                return;
            peca.IncrementaMovimento();
            Tabuleiro.RemoverPecaDaPosicao(destino);
            Tabuleiro.InserirPeca(destino, peca);
        }

        private void PlotarPecas()
        {
            Tabuleiro.InserirPeca(new Posicao('A', 8), new Torre(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('B', 8), new Cavalo(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('C', 8), new Bispo(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('D', 8), new Rei(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('E', 8), new Dama(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('F', 8), new Bispo(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('G', 8), new Cavalo(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('H', 8), new Torre(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('A', 7), new Peao(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('B', 7), new Peao(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('C', 7), new Peao(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('D', 7), new Peao(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('E', 7), new Peao(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('F', 7), new Peao(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('G', 7), new Peao(Cor.Branco));
            Tabuleiro.InserirPeca(new Posicao('H', 7), new Peao(Cor.Branco));


            Tabuleiro.InserirPeca(new Posicao('A', 1), new Torre(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('B', 1), new Cavalo(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('C', 1), new Bispo(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('D', 1), new Rei(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('E', 1), new Dama(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('F', 1), new Bispo(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('G', 1), new Cavalo(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('H', 1), new Torre(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('A', 2), new Peao(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('B', 2), new Peao(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('C', 2), new Peao(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('D', 2), new Peao(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('E', 2), new Peao(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('F', 2), new Peao(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('G', 2), new Peao(Cor.Amarelo));
            Tabuleiro.InserirPeca(new Posicao('H', 2), new Peao(Cor.Amarelo));
        }

    }
}
