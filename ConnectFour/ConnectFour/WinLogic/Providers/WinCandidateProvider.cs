using System.Collections.Generic;
using ConnectFour.Models;
using ConnectFour.WinLogic.WinCandidatesStrategies;

namespace ConnectFour.WinLogic.Providers
{
    public class WinCandidateProvider : IWinCandidateProvider
    {
        private readonly List<IWiningCandidatePositionsStrategy> _winCandidatePositionsStrategies;

        public WinCandidateProvider(List<IWiningCandidatePositionsStrategy> winingCandidatePositionsStrategies)
        {
            _winCandidatePositionsStrategies = winingCandidatePositionsStrategies;
        }

        public IEnumerable<WinCandidate> Provide(Point point)
        {
            var winCases = new List<WinCandidate>();
            foreach (var strategy in _winCandidatePositionsStrategies)
            {
                var candidates = strategy.GetCandidates(point);
                if (candidates == default)
                {
                    continue;
                }
                var winCase = new WinCandidate(strategy.GetCandidates(point));
                winCases.Add(winCase);
            }
            return winCases;
        }
    }
}
