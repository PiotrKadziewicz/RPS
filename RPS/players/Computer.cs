using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.players
{
    class Computer : IPlayer
    {
        public int Score { get; set; }
        public int Rps { get; set; }
    }
}
