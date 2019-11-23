using System;
using System.Collections.Generic;
using System.Text;
using ConnectFour.Models;
using ConnectFour.WinLogic.Factory;
using ConnectFour.WinLogic.Providers;
using Xunit;

namespace ConnectFour.Test.ProviderTests
{
    public class WinCandidatePositionsProvider_Test
    {
        [Fact]
        public void Provide_WhenCalled_ShouldProvide()
        {
            var factory = new WinCandidatePositionsStrategiesFactory(6, 6);
            var sut = new WinCandidatePositionsProvider(factory.Strategies);
            var result = sut.Provide(new Point(2, 0));
        }

    }
}
