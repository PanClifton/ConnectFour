using System.Collections.Generic;
using ConnectFour.Models;

namespace ConnectFour.WinCandidatesStrategies
{
    public class AxisLeftCandidatePositionsStrategy : WiningCandidatePositionsStrategy
    {
        public AxisLeftCandidatePositionsStrategy(int height, int length) : base(height, length)
        {

        }

        public override IEnumerable<Point> GetCandidates(Point point)
        {
            var pointsToCheck = new List<Point>();
            if (point.Y + WinningRangeLength <= Height 
                && point.X - WinningRangeLength + 1 >= 0)
            {
                pointsToCheck.AddRange(Get(point));
            }
            return pointsToCheck;
        }

        private IEnumerable<Point> Get(Point point)
        {
            var pointsToCheck = new List<Point>();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                pointsToCheck.Add(new Point(point.X - i, point.Y + i));
            }
            return pointsToCheck;
        }
    }
}
