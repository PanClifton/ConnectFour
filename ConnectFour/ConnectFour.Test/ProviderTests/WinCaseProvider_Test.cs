using ConnectFour.Models;
using ConnectFour.WinLogic.Factory;
using ConnectFour.WinLogic.Providers;
using Xunit;

namespace ConnectFour.Test.ProviderTests
{
    public class WinCandidateProvider_Test
    {
        [Fact]
        public void Provide_WhenCalled_ShouldProvide()
        {
            var factory = new WinCandidatePositionsStrategiesFactory(6, 6);
            var sut = new WinCandidateProvider(factory.Strategies);
            var result = sut.Provide(new Point(2, 0));
        }

    }
}
