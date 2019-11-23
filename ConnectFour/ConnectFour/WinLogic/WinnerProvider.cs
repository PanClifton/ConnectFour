using System.Collections.Generic;
using ConnectFour.Models;
using ConnectFour.WinLogic.Analyzer;
using ConnectFour.WinLogic.Factory;
using ConnectFour.WinLogic.Providers;

namespace ConnectFour.WinLogic
{
    public class WinnerProvider
    {
        private readonly Board _board;

        private readonly IWinCandidateProvider _winCandidateProvider;
        private readonly WinCasesAnalyzer _winCasesAnalyzer;

        public WinnerProvider(Board board)
        {
            var factory = new WinCandidatePositionsStrategiesFactory(board.NumberOfRows, board.NumberOfColumns);
            _winCandidateProvider = new WinCandidateProvider(factory.Strategies);
            _winCasesAnalyzer = new WinCasesAnalyzer();
            _board = board;
        }
        
        public Winner Provide()
        {
            for (int columnIndex = 0; columnIndex < _board.NumberOfColumns; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < _board.NumberOfRows; rowIndex++)
                {
                    var winner = Provide(new Point(columnIndex, rowIndex));
                    if (winner.IsWinner)
                        return winner;
                }
            }

            return Winner.NoWinner;
        }

        private Winner Provide(Point point)
        {
            var winCandidates = _winCandidateProvider.Provide(point);
            var winCases = new List<WinCase>();
            foreach (var winCandidate in winCandidates)
            {
                var players = _board.GetPlayers(winCandidate.WinCandidatePositions);
                var winCase = new WinCase(players);
                winCases.Add(winCase);
            }

            return _winCasesAnalyzer.GetWinner(winCases);
        }
    }
}
