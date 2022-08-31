using Observer.Ican.System.People.Factories;
using Observer.Ican.System.SleepDiary;

namespace Observer.Ican.System
{
    public static class Program
    {
        public static void Main()
        {
            var sleepLogger = new SleepLogger();
            var people = PersonFactory.Create(3).ToList();
            var subscriptions = people.Select(person => person.Subscribe(sleepLogger)).ToList();

            foreach (var person in people)
            {
                person.GoToBed();
            }

            subscriptions.First().Dispose();
            subscriptions.RemoveAt(0);

            foreach (var person in people)
            {
                person.GoToBed();
            }

            Console.ReadLine();
        }
    }
}
