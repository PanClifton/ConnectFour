using System;
using System.Collections.Generic;
using System.Text;
using ConnectFour.Providers;
using Xunit;
using Xunit.Sdk;

namespace ConnectFour.Test.ProviderTests
{
    public class WinProvider_Tests
    {
        [Fact]
        public void Test()
        {
            var board = new Board(6, 6);

            Player playerOne = new Player("bartek", 'x');
            Player playerTwo = new Player("iza", '0');

            board.Add(new Counter(playerTwo), 5);
            board.Add(new Counter(playerTwo), 4);
            board.Add(new Counter(playerTwo), 3);
            var pos = board.Add(new Counter(playerTwo), 2);
            var sut = new WinProvider(board);
            var win = sut.Provide(pos);
        }
    }
}
