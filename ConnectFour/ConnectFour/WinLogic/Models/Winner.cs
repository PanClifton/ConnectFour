
namespace ConnectFour.Models
{
    public class Winner
    {
        public bool IsWinner { get; }
        public Player Player { get; }

        public Point Start { get; }

        public Point End { get; }

        public static Winner NoWinner => new Winner(false, default);
      
        public Winner(bool isWinner, Player player)
        {
            IsWinner = isWinner;
            Player = player;
        }
    }
}
