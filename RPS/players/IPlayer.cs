using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.players
{
    interface IPlayer
    {
        int Score { get; set; }
        int Rps { get; set; }
    }
}
