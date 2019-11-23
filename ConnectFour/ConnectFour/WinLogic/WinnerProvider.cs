using System;
using System.Collections.Generic;
using System.Text;
using ConnectFour.Models;
using ConnectFour.WinLogic.Factory;
using ConnectFour.WinLogic.Providers;

namespace ConnectFour.WinLogic
{
    public class WinnerProvider
    {
        private readonly IWinCandidateProvider _winCandidateProvider;

        public WinnerProvider(Board board)
        {
            var factory = new WinCandidatePositionsStrategiesFactory(board.NumberOfRows, board.NumberOfColumns);
            _winCandidateProvider = new WinCandidateProvider(factory.Strategies);
        }

        public Winner GetWinner(Point point)
        {
            var winCases = _winCandidateProvider.Provide(point);
            foreach (var winCase in winCases)
            {
                
            }
            return default;
        }
    }
}
