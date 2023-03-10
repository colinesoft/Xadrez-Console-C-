namespace Xadrez.JTabuleiro
{
    public class Tabuleiro: BaseTamanho
    {
        private Peca[,] Pecas = new Peca[Tamanho, Tamanho];

        /// <summary>
        /// Obtem uma peça de acordo com a coluna, linha
        /// </summary>
        /// <param name="coluna"></param>
        /// <param name="linha"></param>
        /// <returns>Peca</returns>
        public Peca Peca(int coluna, int linha)
        {
            PosicaoEhValida(new Posicao(coluna, linha));
            return Pecas[coluna, linha];
        }

        /// <summary>
        /// Obtem uma Peca de cordo com o Posicao
        /// </summary>
        /// <param name="posicao"></param>
        /// <returns>Peca</returns>
        public Peca Peca(Posicao posicao)
        {
            PosicaoEhValida(posicao);
            return this.Peca(posicao.Coluna, posicao.Linha);
        }

        /// <summary>
        /// Marca a posicao com uma determinada peça
        /// </summary>
        /// <param name="posicao"></param>
        /// <param name="peca"></param>
        public void InserirPeca(Posicao posicao, Peca peca)
        {
            ValidaPosicao(posicao);
            Pecas[posicao.Coluna, posicao.Linha] = peca;
            peca.Posicao = posicao;
        }

        /// <summary>
        /// Método utilizado para remover uma peça do tabuleiro na posição informada
        /// </summary>
        /// <param name="posicao"></param>
        public Peca RemoverPecaDaPosicao(Posicao posicao)
        {
            PosicaoEhValida(posicao);
            var aux = Peca(posicao);
            if (aux == null)
                return null;

            aux.Posicao = null;
            Pecas[posicao.Coluna, posicao.Linha] = null;
            return aux;
        }
        #region PRIVATES
        //Testa se posicao é válida
        private bool PosicaoEhValida(Posicao pos)
        {
            return (pos.Linha < ObterTamanhoLateralDoTabuleiro && pos.Linha >= 0) && (pos.Coluna < ObterTamanhoLateralDoTabuleiro && pos.Coluna >= 0);
        }
        private bool PosicaoEstaVazia(Posicao pos)
        {
            PosicaoEhValida(pos);
            return Pecas[pos.Coluna, pos.Linha] == null;
        }

        private void ValidaPosicao(Posicao posicao)
        {
            if (!PosicaoEhValida(posicao))
                throw new TabuleiroExceptions("Tentou inserir uma peça na posicao fora do tabuleiro.");
            if (!PosicaoEstaVazia(posicao))
                throw new TabuleiroExceptions("Já existe uma peça na casa informada");
        }
        #endregion
    }
}
