namespace Xadrez.JTabuleiro
{
    public class Posicao: BaseTamanho
    {
        public int Coluna { get; set; }
        public int Linha { get; set; }

        public Posicao(int coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao(char coluna, int linha)
        {
            Coluna = coluna - 'A';
            Linha =  ObterTamanhoLateralDoTabuleiro - linha;
        }

        public override string ToString()
        {
            return $"{Coluna},{Linha}";
        }
    }
}
