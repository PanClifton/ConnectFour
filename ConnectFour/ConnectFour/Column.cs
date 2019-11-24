using System;

namespace ConnectFour
{
    public class Column
    {
        private int NumberOfRows { get; }
        public Counter[] Counters { get; }

        public Column(int numberOfRows)
        {
            NumberOfRows = numberOfRows;
            Counters = new Counter[numberOfRows];
        }

        public int Add(Counter counter)
        {
            int index = 0;
            if (IsFull())
            {
                return index;
            }
            for (int i = NumberOfRows; i > 0; i--)
            {
                if (Counters[i - 1] == null)
                {
                    Counters[i - 1] = counter;
                    index = i - 1;
                    break;
                }
            }
            return index;
        }

        public void Display()
        {
            for (int i = 0; i < NumberOfRows; i++)
            {
                Console.WriteLine(DisplayRow(i));
            }
        }

        public string DisplayRow(int rowNumber)
        {
            if (Counters[rowNumber]?.Player == null)
            {
                return " ";
            }
            return Counters[rowNumber].Player.Counter.ToString();
        }

        public bool IsFull()
        {
            for (int i = 0; i < Counters.Length; i++)
            {
                if (Counters[i] == null)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}