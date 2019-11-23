using System;
using System.Collections.Generic;
using System.Text;
using ConnectFour.Models;
using ConnectFour.Providers;
using Xunit;

namespace ConnectFour.Test.ProviderTests
{
    public class WinCheckContextProvider_Tests
    {
        public static IEnumerable<object[]> GetPoints()
        {
            yield return new object[] { new Position(1, 5) };
            yield return new object[] { new Position(2, 5) };
            yield return new object[] { new Position(3, 5) };
        }

        [Theory]
        [MemberData(nameof(GetPoints))]
        public void Test(Position position)
        {
            var board = new Board(6, 6);

            Player playerOne = new Player("bartek", 'x');
            Player playerTwo = new Player("iza", '0');

            board.Add(new Counter(playerTwo), 6);
            board.Add(new Counter(playerTwo), 5);
            board.Add(new Counter(playerTwo), 4);
         var pos =   board.Add(new Counter(playerTwo), 3);
            var sut = new WinCheckContextProvider(board);
            var contextsToCheck = sut.Provide(pos);
        }
    }
}
