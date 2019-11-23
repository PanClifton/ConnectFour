using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinLogic.Providers
{
    public interface IWinCandidateProvider
    {
        IEnumerable<WinCandidate> Provide(Point point);
    }
}
