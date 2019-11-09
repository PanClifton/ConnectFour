using System.Runtime.Serialization.Formatters;

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

        public override bool Equals(object obj)
        {
            if (!(obj is Player))
            {
                return false;
            }
            if (ReferenceEquals(this.Player, ((Counter)obj).Player))
            {
                return true;
            }

            return false;
        }
    }
}