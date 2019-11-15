using System;
using System.Linq;

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

        public bool Add(Counter counter)
        {
            if (IsFull())
            {
                return false;
            }
            for (int i = NumberOfRows; i > 0; i--)
            {
                if (Counters[i - 1] == null)
                {
                    Counters[i - 1] = counter;
                    break;
                }
            }
            return true;
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
            // iterujesz przez wszystkie countery
            for (int i = 0; i < Counters.Length; i++)
            {
                //sprawdzasz czy dany counter o indexie 'i' jest nullem jezeli jest zwracasz false
                if (Counters[i] == null)
                {
                    return false;
                }
            }
            // przeiterowales przez wszystkie countery nie bylo nulla wiec zwracasz true;
            return true;
        }
    }
}