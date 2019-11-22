using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
    public class Position
    {
        public uint X { get; }
        public uint Y { get; }

        public Position(uint x, uint y)
        {
            X = x;
            Y = y;
        }
    }
}
