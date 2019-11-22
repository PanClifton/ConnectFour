using System;
using System.Security.Cryptography.X509Certificates;
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

        public Winner GetWinner(Position position)
        {
            bool checkHorizontalLeft = (position.X - WinnerRangeLength > 0);
            bool checkHorizontalRight = (position.X + WinnerRangeLength < _board.NumberOfColumns);
            return null;
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
            var verticalCases = _winningRangeProvider.Provide(column.Counters.Length);

            foreach (var winCase in verticalCases)
            {
                if (column.Counters[winCase.StartIndex] == null)
                {
                    continue;
                }

                var caseToCheck = column.Counters[winCase.StartIndex..(winCase.EndIndex + 1)];
                var allSame = Array.TrueForAll(caseToCheck, x => x.Player == caseToCheck[0].Player);

                if (allSame)
                {
                    return new Winner(true, caseToCheck[0].Player);
                }

            }
            return new Winner(false, default);
        }
    }
}
