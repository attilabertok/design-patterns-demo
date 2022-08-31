using Bogus;
using Observer.Ican.System.Eventing;
using Observer.Ican.System.Eventing.Interfaces;

namespace Observer.Ican.System.People;

public partial class Person :
    IObservable<IEvent>
{
    private readonly HashSet<Subscription> subscriptions = new();

    private readonly Faker faker = new();

    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public IDisposable Subscribe(IObserver<IEvent> observer)
    {
        var subscription = new Subscription(this, observer);
        subscriptions.Add(subscription);

        return subscription;
    }

    public void GoToBed()
    {
        var time = faker.Date.BetweenTimeOnly(new TimeOnly(20, 0), new TimeOnly(23, 59));
        foreach (var subscription in subscriptions)
        {
            subscription.Observer.OnNext(new GoToSleepEvent(this, time));
        }
    }
}
