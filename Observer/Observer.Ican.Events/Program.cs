namespace Observer.Ican.Events
{
    public static class Program
    {
        public static void Main()
        {
            var john = new Person("John");
            john.FallsAsleep += LogGoingToSleep;

            john.GoToBed();

            Console.ReadLine();
        }

        private static void LogGoingToSleep(object? sender, GoToSleepEventArgs eventArgs)
        {
            var name = (sender as Person)?.Name ?? "Someone";
            Console.WriteLine($"{name} is going to sleep at {eventArgs.Time}");
        }
    }
}
