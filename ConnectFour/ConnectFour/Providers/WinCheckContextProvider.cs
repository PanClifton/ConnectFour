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

        public List<WinCheckContext> Provide(Position position)
        {
            var winCheckContext = new List<WinCheckContext>();
            // left horizontal
            if (position.X - WinningRangeLength >= -1)
            {
                winCheckContext.Add(GetLeftHorizontal(position));
            }
            //right horizontal
            if (position.X + WinningRangeLength >= _length)
            {
                winCheckContext.Add(GetRightHorizontal(position));
            }
            //vertical
            if (position.Y + WinningRangeLength <= _height + 1)
            {
                winCheckContext.Add(GetVertical(position));
            }
            //left axis
            if (position.Y + WinningRangeLength <= _height + 1 
                && position.X - WinningRangeLength >= -1)
            {
                winCheckContext.Add(GetLeftAxis(position));
            }
            //right axis
            if (position.Y + WinningRangeLength <= _height + 1 
                && position.X + WinningRangeLength >= _length)
            {
                winCheckContext.Add(GetRightAxis(position));
            }
            return winCheckContext;
        }

        private WinCheckContext GetLeftHorizontal(Position position)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Position(position.X - i, position.Y));
            }
            return winCheckContext;
        }

        private WinCheckContext GetRightHorizontal(Position position)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Position(position.X + i, position.Y));
            }
            return winCheckContext;
        }

        private WinCheckContext GetVertical(Position position)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Position(position.X, position.Y + i));
            }
            return winCheckContext;
        }

        private WinCheckContext GetLeftAxis(Position position)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Position(position.X - i, position.Y + i));
            }
            return winCheckContext;
        }

        private WinCheckContext GetRightAxis(Position position)
        {
            var winCheckContext = new WinCheckContext();
            for (int i = 0; i < WinningRangeLength; i++)
            {
                winCheckContext.AddPositionToCheck(new Position(position.X + i, position.Y + i));
            }
            return winCheckContext;
        }

    }
}
