using System.Collections.Generic;

namespace ConnectFour.Models
{
    public class WinCase
    {
        public List<Player> Players { get; }

        public WinCase(List<Player> players)
        {
            Players = players;
        }
    }
}
