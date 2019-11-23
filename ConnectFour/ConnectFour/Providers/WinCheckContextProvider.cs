using System;
using System.Collections.Generic;
using System.Text;
using ConnectFour.Models;

namespace ConnectFour.Providers
{
    public class WinCheckContextProvider
    {
        private readonly int _height;
        private readonly int _length;
        private const int WinningRangeLength = 4;

        public WinCheckContextProvider(Board board)
        {
            _height = board.NumberOfRows;
            _length = board.NumberOfColumns;
        }

        public List<WinCheckContext> Provide(Point point)
        {
            var winCheckContext = new List<WinCheckContext>();
            // left horizontal
            if (point.X - WinningRangeLength + 1 >= 0)
            {
                winCheckContext.Add(GetLeftHorizontal(point));
            }
            //right horizontal
            if (point.X + WinningRangeLength - 1 <= _length)
            {
                winCheckContext.Add(GetRightHorizontal(point));
            }
            //            //vertical
            //            if (point.Y + WinningRangeLength <= _height + 1)
            //            {
            //                winCheckContext.Add(GetVertical(point));
            //            }
            //            //left axis
            //            if (point.Y + WinningRangeLength <= _height + 1 
            //                && point.X - WinningRangeLength >= -1)
            //            {
            //                winCheckContext.Add(GetLeftAxis(point));
            //            }
            //            //right axis
            //            if (point.Y + WinningRangeLength <= _height + 1 
            //                && point.X + WinningRangeLength >= _length)
            //            {
            //                winCheckContext.Add(GetRightAxis(point));
            //            }
            return winCheckContext;
        }

        private WinCheckContext GetLeftHorizontal(Point point)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Point(point.X - i, point.Y));
            }
            return winCheckContext;
        }

        private WinCheckContext GetRightHorizontal(Point point)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Point(point.X + i, point.Y));
            }
            return winCheckContext;
        }

        private WinCheckContext GetVertical(Point point)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Point(point.X, point.Y + i));
            }
            return winCheckContext;
        }

        private WinCheckContext GetLeftAxis(Point point)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Point(point.X - i, point.Y + i));
            }
            return winCheckContext;
        }

        private WinCheckContext GetRightAxis(Point point)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Point(point.X + i, point.Y + i));
            }
            return winCheckContext;
        }

    }
}
