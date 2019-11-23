using System.Collections.Generic;
using ConnectFour.Models;
using ConnectFour.WinCandidatesStrategies;

namespace ConnectFour.Providers
{
    public class WinCandidatePositionsProvider : IWinCandidatePositionsProvider
    {
        private readonly List<IWiningCandidatePositionsStrategy> _winCandidatePositionsStrategies;

        public WinCandidatePositionsProvider(List<IWiningCandidatePositionsStrategy> winingCandidatePositionsStrategies)
        {
            _winCandidatePositionsStrategies = winingCandidatePositionsStrategies;
        }

        public IEnumerable<Point> Provide(Point point)
        {
            var candidates = new List<Point>();
            foreach (var strategy in _winCandidatePositionsStrategies)
            {
                candidates.AddRange(strategy.GetCandidates(point));
            }
            return candidates;
        }
    }
}
