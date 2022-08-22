using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestASP.Models
{
    public class ComputerMove
    {
        public int Move { get; set; }

        public ComputerMove(int move)
        {
            Move = move;
        }
    }
}

