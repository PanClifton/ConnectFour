using System;
using System.Collections.Generic;
using System.Text;
using ConnectFour.Models;

namespace ConnectFour.Strategy
{
    public interface IWiningCandidatePositionsStrategy
    {
        IEnumerable<Point> GetCandidates(Point point);
    }
}
