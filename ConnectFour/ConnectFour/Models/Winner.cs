
namespace ConnectFour.Models
{
    public class Winner
    {
        public bool IsWinner { get; private set; }
        public Player Player { get; private set; }


        public Winner()
        {

        }
        public Winner(bool isWinner, Player player)
        {
            IsWinner = isWinner;
            Player = player;
        }

        public void Update(Winner winner)
        {
            this.Player = winner.Player;
            this.IsWinner = winner.IsWinner;
        }
    }
}
