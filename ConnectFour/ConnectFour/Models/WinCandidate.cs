using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour.Models
{
    public class WinCandidate
    {
        public List<Point> WinCandidatePositions { get; }

        public WinCandidate(List<Point> winPositions)
        {
            WinCandidatePositions = winPositions;
        }
    }
}
