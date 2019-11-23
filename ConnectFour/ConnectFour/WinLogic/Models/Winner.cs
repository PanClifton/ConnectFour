
namespace ConnectFour.Models
{
    public class Winner
    {
        public static Winner NoWinner => new Winner(false);

        public bool IsWinner { get; }
        public Player Player { get; }
       

        public Winner(bool isWinner)
        {
            IsWinner = isWinner;
        }

        public Winner(bool isWinner, Player player) : this(isWinner)
        {
            Player = player;
        }
    }
}
