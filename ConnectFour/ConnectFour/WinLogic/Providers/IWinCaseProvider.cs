using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinLogic.Providers
{
    public interface IWinCaseProvider
    {
        IEnumerable<WinCase> Provide(Point point);
    }
}
