using System.Collections.Generic;
using ConnectFour.WinLogic.WinCandidatesStrategies;

namespace ConnectFour.WinLogic.Factory
{
    public class WinCandidatePositionsStrategiesFactory
    {
        public List<IWiningCandidatePositionsStrategy> Strategies { get; }

        public WinCandidatePositionsStrategiesFactory(int height, int length)
        {
            Strategies = new List<IWiningCandidatePositionsStrategy>
            {
                new AxisLeftCandidatePositionsStrategy(height, length),
                new AxisRightCandidatePositionsStrategy(height, length),
                new HorizontalLeftCandidatePositionsStrategy(height, length),
                new HorizontalRightCandidatePositionsStrategy(height, length),
                new VerticalCandidatePositionsStrategy(height, length)
            };
        }

    }
}
