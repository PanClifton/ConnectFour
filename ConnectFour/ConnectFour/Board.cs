using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using ConnectFour.Provider;

namespace ConnectFour
{
    public class Board
    {
        private const int WinnerRangeLength = 4;
        private readonly Column[] _columns;

        private readonly int _numberOfRows;
        private readonly int _numberOfColumns;

        private readonly WinningRangeProvider _winningRangeProvider;
        public Board(int numberOfRows, int numberOfColumns)
        {
            _numberOfColumns = numberOfColumns;
            _numberOfRows = numberOfRows;

            _columns = new Column[numberOfColumns];
            for (int i = 0; i < numberOfColumns; i++)
            {
                _columns[i] = new Column(numberOfRows);
            }
            _winningRangeProvider = new WinningRangeProvider(WinnerRangeLength);
        }

        public bool Add(Counter counter, int columnNumber)
        {
            if (!_columns[columnNumber].IsFull())
            {
               return _columns[columnNumber].Add(counter);
            }

            return false;
        }

        public void Display()
        {
            var header = string.Empty;
            for (int i = 0; i < _numberOfColumns; i++)
            {
                header = header + GetCell(i, i.ToString());
            }

            var lineUnderHeader = string.Empty;
            for (int i = 0; i < _numberOfColumns; i++)
            {
                lineUnderHeader = lineUnderHeader + "--";
            }

            Console.WriteLine(header);
            Console.WriteLine(lineUnderHeader);

            DisplayContent();
        }

        private void DisplayContent()
        {
            for (int i = 0; i < _numberOfRows; i++)
            {
                var row = string.Empty;
                for (int j = 0; j < _numberOfColumns; j++)
                {
                    row = row + GetCell(j, _columns[j].DisplayRow(i));
                }
                Console.WriteLine(row);
            }
        }

        public bool IsFull()
        {
            // iterujesz przez columny
            for (int i = 0; i < _columns.Length; i++)
            {
                // sprawdz czy dana kolumna o indexie i jest pelna wykorzystujac jej metode Is() full
                // jezeli nie jest zwroc false
                // ! znaczy negacja np NOT IsFull
                if (!_columns[i].IsFull())
                {
                    return false;
                }
            }
            // przeiterowales przez wszystkie kolumny wszystkie byly pelne wiec zwracasz true
            return true;
        }

        private string GetCell(int i, string value)
        {
            var firstBreak = string.Empty;
            if (i == 0)
            {
                firstBreak = "|";
            }

            return $"{firstBreak}{value}|";
        }

        public Player CheckWinner()
        {           

            return null;
        }

        private Player CheckColumns()
        {
            for (int i = 0; i < _numberOfColumns; i++)
            {
                CheckColumn(_columns[i]);
            }
            return null;
        }

        private Player CheckColumn(Column column)
        {
            var winCases = _winningRangeProvider.Provide(column.Counters.Length);
            foreach (var winCase in winCases)
            {
                
            }
            return null;
        }

        private Player CheckFlatWinCase(WinningRange winningRange, Column column)
        {
            
            for (int i = winningRange.StartIndex; i < winningRange.EndIndex; i++)
            {
                var player = column.Counters[i].Player;
                if (player == null)
                {
                    return null;
                }

            }
            return null;
        }

      
    }
}
