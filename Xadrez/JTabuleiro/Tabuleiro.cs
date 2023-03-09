namespace Xadrez.JTabuleiro
{
    public class Tabuleiro
    {
        private const int _Colunas = 8;
        private const int _Linhas = _Colunas;
        private Peca[,] Pecas = new Peca[_Colunas, _Linhas];

        /// <summary>
        /// Obtem uma peça de acordo com a coluna, linha
        /// </summary>
        /// <param name="coluna"></param>
        /// <param name="linha"></param>
        /// <returns>Peca</returns>
        public Peca Peca(int coluna, int linha)
        {
            return Pecas[coluna, linha];
        }

        /// <summary>
        /// Obtem uma Peca de cordo com o Posicao
        /// </summary>
        /// <param name="posicao"></param>
        /// <returns>Peca</returns>
        public Peca Peca(Posicao posicao)
        {
            return this.Peca(posicao.Coluna, posicao.Linha);
        }

        /// <summary>
        /// Obtem a quantidade de Colunas do Tabuleiro
        /// </summary>
        public int GetCasasPorColunas => _Colunas;

        /// <summary>
        /// Obtem a quantidade de Linhas do Tabuleiro
        /// </summary>
        public int GetCasasPorLinhas => _Linhas;

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

        #region PRIVATES
        //Testa se posicao é válida
        private bool PosicaoEhValida(Posicao pos)
        {
            return (pos.Linha < GetCasasPorLinhas && pos.Linha >= 0) && (pos.Coluna < GetCasasPorColunas && pos.Coluna >= 0);
        }
        private bool PosicaoEstaVazia(Posicao pos)
        {
            Peca peca = Peca(pos.Coluna, pos.Linha);
            return peca == null;
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
