namespace Xadrez.JTabuleiro
{
    public abstract class Peca
    {
        public Posicao Posicao {get; set;}
        public Cor Cor { get; protected set; }
        public int TotalMovimentos { get; protected set; }

        public Peca(Cor cor)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.TotalMovimentos = 0;
        }

        public void IncrementaMovimento()
        {
            TotalMovimentos++;
        }
    }
}
