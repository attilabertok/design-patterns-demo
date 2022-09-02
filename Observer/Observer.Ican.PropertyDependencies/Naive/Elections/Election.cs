using Observer.Ican.PropertyDependencies.Naive.Infrastructure.Models;

namespace Observer.Ican.PropertyDependencies.Naive.Elections;

public class Election
    : NaiveModelBase
{
    public Election(string country, DateOnly date)
    {
        Country = country;
        Date = date;
    }

    public string Country { get; }

    public DateOnly Date { get; }
}
