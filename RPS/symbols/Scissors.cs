using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.symbols
{
    class Scissors : ISymbol
    {
        public string Name
        {
            get
            {
                return "Scissors";
            }
        }

        public int Code
        {
            get
            {
                return 51;
            }
        }
    }
}
