using Bogus;

namespace Observer.Ican.System.People.Factories;

public static class PersonFactory
{
    public static Person Create()
    {
        return new Person(new Faker().Person.FullName);
    }

    public static IEnumerable<Person> Create(int count)
    {
        return Enumerable.Range(0, count)
            .Select(_ => Create());
    }
}
