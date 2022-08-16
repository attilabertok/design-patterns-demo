using Bogus;

namespace Strategy.Ican.EqualityAndComparison;

public static class PersonFactory
{
    public static Person Create()
    {
        var faker = new Faker();

        return new Person(faker.Person.FullName, DateOnly.FromDateTime(faker.Person.DateOfBirth));
    }

    public static ICollection<Person> Create(int count)
    {
        return Enumerable.Range(0, count)
            .Select(_ => Create())
            .ToList();
    }
}
