using System.Collections.Generic;
using ConnectFour.Models;
using ConnectFour.WinLogic.WinCandidatesStrategies;

namespace ConnectFour.WinLogic.Providers
{
    public class WinCaseProvider : IWinCaseProvider
    {
        private readonly List<IWiningCandidatePositionsStrategy> _winCandidatePositionsStrategies;

        public WinCaseProvider(List<IWiningCandidatePositionsStrategy> winingCandidatePositionsStrategies)
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
