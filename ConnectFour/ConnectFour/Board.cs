using System;
using ConnectFour.Models;

namespace ConnectFour
{
    public class Board
    {
        public Column[] Columns { get; }

        public int NumberOfRows { get; }
        public int NumberOfColumns { get; }
        public Board(int numberOfRows, int numberOfColumns)
        {
            NumberOfColumns = numberOfColumns;
            NumberOfRows = numberOfRows;

            Columns = new Column[numberOfColumns];
            for (int i = 0; i < numberOfColumns; i++)
            {
                Columns[i] = new Column(numberOfRows);
            }
        
        }

        public Point Add(Counter counter, int columnNumber)
        {
            int x = columnNumber;
            int y = 0;
            if (!Columns[columnNumber].IsFull())
            {
                y = Columns[columnNumber].Add(counter);
            }

            return new Point(x, y);
        }

        public void Display()
        {
            var header = string.Empty;
            for (int i = 0; i < NumberOfColumns; i++)
            {
                header = header + GetCell(i, i.ToString());
            }

            var lineUnderHeader = string.Empty;
            for (int i = 0; i < NumberOfColumns; i++)
            {
                lineUnderHeader = lineUnderHeader + "--";
            }

            Console.WriteLine(header);
            Console.WriteLine(lineUnderHeader);

            DisplayContent();
        }

        private void DisplayContent()
        {
            for (int i = 0; i < NumberOfRows; i++)
            {
                var row = string.Empty;
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    row = row + GetCell(j, Columns[j].DisplayRow(i));
                }
                Console.WriteLine(row);
            }
        }

        public bool IsFull()
        {
            // iterujesz przez columny
            for (int i = 0; i < Columns.Length; i++)
            {
                // sprawdz czy dana kolumna o indexie 'i' jest pelna wykorzystujac jej metode Is() full
                // jezeli nie jest zwracasz false
                // ! znaczy negacja === NOT IsFull
                if (!Columns[i].IsFull())
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
    }
}
