using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour.Models
{
    public class WinCheckContext
    {
        public List<Point> PositionsToCheck { get; private set; }

        public WinCheckContext()
        {
            PositionsToCheck = new List<Point>();
        }

        public void AddPositionToCheck(Point point)
        {
            PositionsToCheck.Add(point);
        }
    }
}
