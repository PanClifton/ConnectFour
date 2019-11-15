using ConnectFour.Provider;
using FluentAssertions;
using Xunit;

namespace ConnectFour.Test.ProviderTests
{
    public class WinnerRangeLength_Tests
    {
        [Theory]
        [InlineData(6)]

        public void Provide_WhenCalled_ShouldProvide(int arrayLength)
        {
            var winnigRangeLength = 3;
            var sut = new WinningRangeProvider(winnigRangeLength);
            var result = sut.Provide(arrayLength);
        }
    }
}
