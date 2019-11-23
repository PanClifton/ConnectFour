using System.Collections.Generic;
using ConnectFour.Models;
using ConnectFour.WinCandidatesStrategies;

namespace ConnectFour.Providers
{
    public class WinCandidatePositionsProvider : IWinCaseProvider
    {
        private readonly List<IWiningCandidatePositionsStrategy> _winCandidatePositionsStrategies;

        public WinCandidatePositionsProvider(List<IWiningCandidatePositionsStrategy> winingCandidatePositionsStrategies)
        {
            _winCandidatePositionsStrategies = winingCandidatePositionsStrategies;
        }

        public IEnumerable<WinCase> Provide(Point point)
        {
            var winCases = new List<WinCase>();
            foreach (var strategy in _winCandidatePositionsStrategies)
            {
                var candidates = strategy.GetCandidates(point);
                if (candidates == default)
                {
                    continue;
                }
                var winCase = new WinCase(strategy.GetCandidates(point));
                winCases.Add(winCase);
            }
            return winCases;
        }
    }
}
