using Observer.Ican.System.Eventing.Interfaces;

namespace Observer.Ican.System.People;

public partial class Person
{
    private class Subscription : IDisposable
    {
        private readonly Person person;

        public Subscription(Person person, IObserver<IEvent> observer)
        {
            Observer = observer;
            this.person = person;
        }

        public IObserver<IEvent> Observer { get; }

        public void Dispose()
        {
            Console.WriteLine($"{person.Name} is no longer using the app.");
            person.subscriptions.Remove(this);
        }
    }
}
