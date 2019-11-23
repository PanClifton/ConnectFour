using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.Providers
{
    public interface IWinCandidatePositionsProvider
    {
        IEnumerable<Point> Provide(Point point);
    }
}
