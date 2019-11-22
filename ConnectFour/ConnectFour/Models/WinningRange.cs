namespace ConnectFour.Models
{
    public class WinningRange
    {
        public int StartIndex { get; }
        public int EndIndex { get; }

        public WinningRange(int start, int end)
        {
            StartIndex = start;
            EndIndex = end;
        }
    }
}
