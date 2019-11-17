
namespace ConnectFour
{
    public class Winner
    {
        public bool IsWinner { get; }
        public Player Player { get; }

        public Winner(bool isWinner, Player player)
        {
            IsWinner = isWinner;
            Player = player;
        }
    }
}
