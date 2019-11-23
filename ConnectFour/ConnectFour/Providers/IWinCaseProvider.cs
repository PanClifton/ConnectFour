using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.Providers
{
    public interface IWinCaseProvider
    {
        IEnumerable<WinCase> Provide(Point point);
    }
}
