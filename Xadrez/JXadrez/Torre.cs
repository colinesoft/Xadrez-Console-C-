using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.JTabuleiro;

namespace Xadrez.JXadrez
{
    public class Torre: Peca
    {
        public Torre(Cor cor) : base(cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
