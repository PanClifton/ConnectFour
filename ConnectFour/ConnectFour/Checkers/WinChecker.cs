
using System;
using System.Linq;
using ConnectFour.Provider;

namespace ConnectFour.Checkers
{
    public class WinChecker
    {
        private const int WinnerRangeLength = 4;
        private readonly WinningRangeProvider _winningRangeProvider;
        private readonly Board _board;


        public WinChecker(Board board)
        {
            _winningRangeProvider = new WinningRangeProvider(WinnerRangeLength);
            _board = board;
        }

        public Winner Check()
        {
            return CheckColumns();
        }

        private Winner CheckColumns()
        {
            foreach (var column in _board.Columns)
            {
                var winner = CheckColumn(column);
                if (winner.IsWinner)
                {
                    return winner;
                }
            }
            return new Winner(false, default);
        }

        private Winner CheckColumn(Column column)
        {
            var horizontalCases = _winningRangeProvider.Provide(column.Counters.Length);

            foreach (var winCase in horizontalCases)
            {
                if (column.Counters[winCase.StartIndex] == null)
                {
                    continue;
                }

                var arrayToCheck = column.Counters[winCase.StartIndex..winCase.EndIndex];
                var allSame = Array.TrueForAll(arrayToCheck, x => x.Player == arrayToCheck[0].Player);
               
                if (allSame)
                {
                    return new Winner(true, arrayToCheck[0].Player);
                }

            }
            return new Winner(false, default);
        }
      
    }
}
