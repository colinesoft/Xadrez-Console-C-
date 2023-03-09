namespace Xadrez.JTabuleiro
{
    public class Posicao
    {
        public int Coluna { get; set; }
        public int Linha { get; set; }

        public Posicao(int coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public override string ToString()
        {
            return $"{Coluna},{Linha}";
        }
    }
}
