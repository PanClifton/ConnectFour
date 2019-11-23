using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinCandidatesStrategies
{
    public interface IWiningCandidatePositionsStrategy
    {
        List<Point> GetCandidates(Point point);
    }
}
