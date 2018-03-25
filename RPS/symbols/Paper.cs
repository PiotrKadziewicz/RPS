using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.symbols
{
    class Paper : ISymbol
    {
        public string Name
        {
            get
            {
                return "Paper";
            }
        }

        public int Code
        {
            get
            {
                return 50;
            }

        }
    }
}
