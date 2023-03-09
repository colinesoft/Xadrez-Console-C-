using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.JTabuleiro;

namespace Xadrez.JXadrez
{
    public class Peao: Peca
    {
        public Peao(Cor cor) : base(cor)
        {

        }

        public override string ToString()
        {
            return "P";
        }
    }
}
