namespace Observer.Ican.RatGame
{
    public static class Program
    {
        private static readonly List<Rat> Rats = new();

        public static void Main()
        {
            var game = new Game();
            AddRats(game, 3);
            RemoveRats(1);
        }

        private static void AddRats(Game game, int count)
        {
            for (var i = 0; i < count; i++)
            {
                AddRat(game);
            }
        }

        private static void AddRat(Game game)
        {
            var rat = new Rat(game);
            Rats.Add(rat);
            Console.WriteLine($"added a rat - total count: {Rats.Count}");
            for (var index = 0; index < Rats.Count; index++)
            {
                var r = Rats[index];
                Console.WriteLine($"rat {index + 1} attack is: {r.Attack}");
            }
        }

        private static void RemoveRats(int count)
        {
            for (var i = 0; i < count && Rats.Count > 0; i++)
            {
                RemoveRat();
            }
        }

        private static void RemoveRat()
        {
            var rat = Rats.Last();
            Rats.Remove(rat);
            rat.Dispose();
            Console.WriteLine($"removed a rat - total count: {Rats.Count}");
            for (var index = 0; index < Rats.Count; index++)
            {
                var r = Rats[index];
                Console.WriteLine($"rat {index + 1} attack is: {r.Attack}");
            }
        }
    }
}
