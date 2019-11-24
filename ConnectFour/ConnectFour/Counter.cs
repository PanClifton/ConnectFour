namespace ConnectFour
{
    public class Counter
    {
        public Player Player { get; }

        public Counter(Player player)
        {
            Player = player;
        }

        public override string ToString()
        {
            return Player.Counter.ToString();
        }
    }
}