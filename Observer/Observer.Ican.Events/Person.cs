using Bogus;

namespace Observer.Ican.Events;

public class Person
{
    private readonly Faker faker = new();

    public Person(string name)
    {
        Name = name;
    }

    public event EventHandler<GoToSleepEventArgs>? FallsAsleep;

    public string Name { get; }

    public void GoToBed()
    {
        var time = faker.Date.BetweenTimeOnly(new TimeOnly(20, 0), new TimeOnly(23, 59));
        FallsAsleep?.Invoke(this, new GoToSleepEventArgs(time));
    }
}
