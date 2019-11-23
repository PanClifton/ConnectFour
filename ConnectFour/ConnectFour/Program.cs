using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConnectFour
{
    class Program
    {
        static void Main(string[] args)
        {
//            TestTask1();
//            TestTask2a();
//            TestTask2e();
//            TestTask3();

            Main().GetAwaiter().GetResult();
        }

        public static Task Main()
        {
            Task4().ConfigureAwait(false);
            return Task.CompletedTask;
        }

        static void TestTask1()
        {
            Console.WriteLine("task 1");
            Player p1 = new Player("Clive", 'x');
            Player p2 = new Player("Bartek", 'x');

            Counter c = new Counter(p1);
            Counter c1 = new Counter(p1);
            Counter c2 = new Counter(p2);

            Console.WriteLine(c.Player + ", " + c);
        }

        static void TestTask2a()
        {
            Console.WriteLine("task 2a");
            Player p1 = new Player("Clive", 'x');

            var number = 4;
            Column column = new Column(number);
            for (int i = 0; i < number + 1; i++)
            {
                var result = column.Add(new Counter(p1));
                Console.WriteLine(result);
            }
        }

        static void TestTask2e()
        {
            Console.WriteLine("task 2e");
            Player p1 = new Player("Clive", 'o');
            Player p2 = new Player("Sharon", 'x');

            var number = 6;
            Column column = new Column(number);
            for (int i = 0; i < 3; i++)
            {
                column.Add(new Counter(p1));
                column.Add(new Counter(p2));
            }
            column.Display();
        }

        static void TestTask3()
        {
            Console.WriteLine("task 3d");
            Board board = new Board(6, 7);
            Player p1 = new Player("Clive", 'o');
            Player p2 = new Player("Sharon", 'x');

            board.Add(new Counter(p2), 6);
            board.Add(new Counter(p1), 3);
            board.Add(new Counter(p2), 4);
            board.Add(new Counter(p1), 4);
            board.Add(new Counter(p2), 5);
            board.Add(new Counter(p1), 5);
            board.Add(new Counter(p2), 6);
            board.Add(new Counter(p1), 5);
            board.Add(new Counter(p2), 6);
            board.Add(new Counter(p1), 6);

            board.Display();
            Console.WriteLine(board.IsFull());
        }

        static Task Task4()
        {
            Console.Clear();
            var numberOfColumns = 6;
            var numberOfRows = 6;
            Board board = new Board(numberOfRows, numberOfColumns);
     
            Player p1 = new Player("Clive", 'o');
            Player p2 = new Player("Sharon", 'x');

            Random rnd = new Random();
            int i = 0;
            while (!board.IsFull())
            {
                i++;
                var randomColumn = rnd.Next(0, numberOfColumns);

                var position = board.Add(i % 2 == 0 ? new Counter(p1) : new Counter(p2), randomColumn);
                {
                    Thread.Sleep(TimeSpan.FromMilliseconds(320));
                }


                Console.WriteLine(string.Empty);
                Console.Clear();
                board.Display();
            }
            return Task.CompletedTask;
        }

    }
}
