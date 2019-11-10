using System;
using System.Linq;

namespace ConnectFour
{
    public class Board
    {
        private const int WinnerLength = 4;
        private readonly Column[] _columns;

        private readonly int _numberOfRows;
        private readonly int _numberOfColumns;

        public Board(int numberOfRows, int numberOfColumns)
        {
            _numberOfColumns = numberOfColumns;
            _numberOfRows = numberOfRows;

            _columns = new Column[numberOfColumns];
            for (int i = 0; i < numberOfColumns; i++)
            {
                _columns[i] = new Column(numberOfRows);
            }
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
            return _columns.All(x => x.IsFull());
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
            for (int i = 0; i < _numberOfColumns; i++)
            {
              
            }

            return null;
        }

        private Player CheckColumn(int index)
        {
            for (int i = 0; i < _columns.Length - WinnerLength; i++)
            {
                for (int j = i; j < WinnerLength; j++)
                {

                }
            }

            return null;
        }

    }
}
