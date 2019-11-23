using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ConnectFour.Models;

namespace ConnectFour.Strategy
{
    public abstract class WiningCandidatePositionsStrategy : IWiningCandidatePositionsStrategy
    {
        protected readonly int Height;
        protected readonly int Length;

        protected const int WinningRangeLength = 4;

        protected WiningCandidatePositionsStrategy(int height, int length)
        {
            Height = height;
            Length = length;
        }

        public abstract IEnumerable<Point> GetPoints(Point point);

    }
}
