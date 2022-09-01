using Observer.Ican.PropertyDependencies.Infrastructure.Models;

namespace Observer.Ican.PropertyDependencies.Elections;

public class Election
    : ModelBase
{
    public Election(string country, DateOnly date)
    {
        Country = country;
        Date = date;
    }

    public string Country { get; }

    public DateOnly Date { get; }
}
