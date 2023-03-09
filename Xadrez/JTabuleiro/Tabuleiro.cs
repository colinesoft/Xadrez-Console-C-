namespace Xadrez.JTabuleiro
{
    public class Tabuleiro
    {
        private const int _Colunas = 8;
        private const int _Linhas = _Colunas;
        private Peca[,] Pecas = new Peca[_Colunas, _Linhas];

        public Peca Peca(int coluna, int linha)
        {
            return Pecas[coluna, linha];
        }
        public int GetCasasPorColunas => _Colunas;
        public int GetCasasPorLinhas => _Linhas;
        public void InserirPeca(Posicao posicao, Peca peca)
        {
            Pecas[posicao.Coluna, posicao.Linha] = peca;
            peca.Posicao = posicao;
        }
    }
}
