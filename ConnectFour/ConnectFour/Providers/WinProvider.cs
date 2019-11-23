using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConnectFour.Models;

namespace ConnectFour.Providers
{
    public class WinProvider
    {
        private readonly WinCheckContextProvider _winCheckContextProvider;
        private readonly Board _board;

        public WinProvider(Board board)
        {
            _winCheckContextProvider = new WinCheckContextProvider(board);
            _board = board;
        }

        public Winner Provide(Position position)
        {
            var winner = new Winner();
            var winCasesToCheck = _winCheckContextProvider.Provide(position);
            foreach (var winCase in winCasesToCheck)
            {
                winner.Update(CheckForWin(winCase.PositionsToCheck));
            }
            return winner;
        }

        private Player GetPlayer(Position position)
        {
            return _board.Columns[position.Y]?.GetPlayer(position.X);
        }

        private Winner CheckForWin(List<Position> positions)
        {
            List<Player> players = new List<Player>();
            var winner = new Winner();
            foreach (var position in positions)
            {
                var player = GetPlayer(position);
                if (player == null)
                {
                    break;
                }

                players.Add(player);
            }

            if (players.Count == 4)
            {
                winner.Update(new Winner(true, players[0]));
            }
            if (players.Any(o => o != players[0]))
            {
               
            }

            return winner;
        }
    }
}
