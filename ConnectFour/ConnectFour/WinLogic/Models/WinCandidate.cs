using System.Collections.Generic;

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
