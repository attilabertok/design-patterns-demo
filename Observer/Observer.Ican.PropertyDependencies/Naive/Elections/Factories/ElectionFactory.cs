using Bogus;

namespace Observer.Ican.PropertyDependencies.Naive.Elections.Factories;

public static class ElectionFactory
{
    public static Election Create(string? country = null)
    {
        var faker = new Faker();

        return new Election(country ?? faker.Address.Country(), faker.Date.SoonDateOnly());
    }
}
