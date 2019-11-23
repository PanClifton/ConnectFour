using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinCandidatesStrategies
{
    public interface IWiningCandidatePositionsStrategy
    {
        IEnumerable<Point> GetCandidates(Point point);
    }
}
