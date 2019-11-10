using System.Collections.Generic;
using System.ComponentModel;

namespace ConnectFour.Provider
{
    public class WinningRangeProvider
    {
        public List<WinningRange> Provide(int length, int winningRangeLength)
        {
            var numberOfWinningRangesInLength = length - winningRangeLength;
            var winningCases = new List<WinningRange>();

            for (int i = 0; i < numberOfWinningRangesInLength; i++)
            {
                winningCases.Add(new WinningRange(i, i + winningRangeLength));
            }
            return winningCases;
        }
    }
}
