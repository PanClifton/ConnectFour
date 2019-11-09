using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectFour
{
    public class Player
    {
        public string Name { get; }
        public char Counter { get; }

        public Player(string name, char counter)
        {
            Name = name;
            Counter = counter;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}