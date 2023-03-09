using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.JTabuleiro
{
    public class TabuleiroExceptions : ApplicationException
    {
        public TabuleiroExceptions(string e) : base(e)
        {

        }
    }
}
