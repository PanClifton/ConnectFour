using ConnectFour.Checkers;
using Xunit;

namespace ConnectFour.Test.CheckersTests
{
    public class WinChecker_Tests
    {
        [Fact]
        public void TestWin()
        {
            Board board = new Board(6, 10);
            Player p1 = new Player("Clive", 'o');

            board.Add(new Counter(p1), 0);
            board.Add(new Counter(p1), 0);
            board.Add(new Counter(p1), 0);
            board.Add(new Counter(p1), 0);
            var sut = new WinChecker(board);
            var resutl = sut.Check();
        }
    }
}
