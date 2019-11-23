using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinCandidatesStrategies
{
    public class VerticalCandidatePositionsStrategy : WiningCandidatePositionsStrategy
    {
        public VerticalCandidatePositionsStrategy(int height, int length) : base(height, length)
        {

        }

        public override List<Point> GetCandidates(Point point)
        {
            var pointsToCheck = new List<Point>();
            if (point.Y + WinningRangeLength <= Height)
            {
                pointsToCheck.AddRange(Get(point));
            }
            else
            {
                return default;
            }
            return pointsToCheck;
        }

        private IEnumerable<Point> Get(Point point)
        {
            var pointsToCheck = new List<Point>();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                pointsToCheck.Add(new Point(point.X, point.Y + i));
            }
            return pointsToCheck;
        }
    }
}
