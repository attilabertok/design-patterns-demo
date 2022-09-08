using Bogus;

namespace Decorator.Dive.Notifier.Common.Subscribers.Factories;

public static class SubscriberFactory
{
    public static Subscriber Create()
    {
        var faker = new Faker();

        return new Subscriber(
            faker.Person.FullName,
            faker.Person.Email,
            faker.Person.Phone,
            faker.Random.Guid());
    }
}
