using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinLogic.WinCandidatesStrategies
{
    public interface IWiningCandidatePositionsStrategy
    {
        List<Point> GetCandidates(Point point);
    }
}
