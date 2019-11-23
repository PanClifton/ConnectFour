using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinLogic.WinCandidatesStrategies
{
    public abstract class WiningCandidatePositionsStrategy : IWiningCandidatePositionsStrategy
    {
        protected readonly int Height;
        protected readonly int Length;

        protected const int WinningRangeLength = 3;

        protected WiningCandidatePositionsStrategy(int height, int length)
        {
            Height = height;
            Length = length;
        }

        public abstract List<Point> GetCandidates(Point point);
    }
}
