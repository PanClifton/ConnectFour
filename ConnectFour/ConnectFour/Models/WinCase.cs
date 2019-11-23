using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour.Models
{
    public class WinCase
    {
        public List<Point> WinCandidatePositions { get; }

        public WinCase(List<Point> winPositions)
        {
            WinCandidatePositions = winPositions;
        }
    }
}
