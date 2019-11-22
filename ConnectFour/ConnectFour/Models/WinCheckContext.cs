using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour.Models
{
    public class WinCheckContext
    {
        public List<Position> PositionsToCheck { get; private set; }

        public WinCheckContext()
        {
            PositionsToCheck = new List<Position>();
        }

        public void AddPositionToCheck(Position position)
        {
            PositionsToCheck.Add(position);
        }
    }
}
