using System.Collections.Generic;
using System.ComponentModel;

namespace ConnectFour.Provider
{
    public class WinningRangeProvider
    {
        private readonly int _winningRangeLength;

        public WinningRangeProvider(int winningRangeLength)
        {
            _winningRangeLength = winningRangeLength;
        }

        public List<WinningRange> Provide(int length)
        {
            var numberOfWinningRangesInLength = length - _winningRangeLength + 1;
            var winningCases = new List<WinningRange>();

            for (int i = 0; i < numberOfWinningRangesInLength; i++)
            {
                winningCases.Add(new WinningRange(i, i + _winningRangeLength - 1));
            }
            return winningCases;
        }
    }
}
