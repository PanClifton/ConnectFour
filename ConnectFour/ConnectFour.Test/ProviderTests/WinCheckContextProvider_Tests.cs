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
        [Fact]
        public void Test()
        {
            var board = new Board(6,6);

            var position = new Position(3, 3);

            var sut = new WinCheckContextProvider(board);
            var contextsToCheck = sut.Provide(position);
        }
    }
}
