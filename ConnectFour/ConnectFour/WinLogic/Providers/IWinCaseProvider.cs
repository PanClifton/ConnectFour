using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinLogic.Providers
{
    public interface IWinCaseProvider
    {
        IEnumerable<WinCandidate> Provide(Point point);
    }
}
