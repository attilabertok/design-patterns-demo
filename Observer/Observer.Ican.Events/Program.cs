using Observer.Ican.Events.People;
using Observer.Ican.Events.People.Factories;

namespace Observer.Ican.Events
{
    public static class Program
    {
        public static void Main()
        {
            var people = PersonFactory.Create(3).ToList();
            foreach (var person in people)
            {
                person.FallsAsleep += LogGoingToSleep;
            }

            foreach (var person in people)
            {
                person.GoToBed();
            }

            Console.ReadLine();
        }

        private static void LogGoingToSleep(object? sender, GoToSleepEventArgs eventArgs)
        {
            var name = (sender as Person)?.Name ?? "Someone";
            Console.WriteLine($"{name} is going to sleep at {eventArgs.Time}");
        }
    }
}
