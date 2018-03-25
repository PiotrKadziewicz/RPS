using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.symbols
{
    class Rock : ISymbol
    {
        public string Name
        {
            get
            {
                return "Rock";
            }
            set { }
        }

        public int Code
        {
            get
            {
                return 49;
            }
            set { }
        }

    }
}
