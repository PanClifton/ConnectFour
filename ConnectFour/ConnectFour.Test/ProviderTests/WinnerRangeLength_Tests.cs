using ConnectFour.Providers;
using FluentAssertions;
using Xunit;

namespace ConnectFour.Test.ProviderTests
{
    public class WinnerRangeLength_Tests
    {
        [Theory]
        [InlineData(5)]

        public void Provide_WhenCalled_ShouldProvide(int arrayLength)
        {
            var winnigRangeLength = 4;
            var sut = new WinningRangeProvider(winnigRangeLength);
            var result = sut.Provide(arrayLength);
            
        }
    }
}
