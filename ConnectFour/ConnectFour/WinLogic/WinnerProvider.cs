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
        private readonly IWinCaseProvider _winCaseProvider;

        public WinnerProvider(Board board)
        {
            var factory = new WinCandidatePositionsStrategiesFactory(board.NumberOfRows, board.NumberOfColumns);
            _winCaseProvider = new WinCaseProvider(factory.Strategies);
        }

        public Winner GetWinner(Point point)
        {
            var winCases = _winCaseProvider.Provide(point);
            foreach (var winCase in winCases)
            {
                
            }
            return default;
        }
    }
}
