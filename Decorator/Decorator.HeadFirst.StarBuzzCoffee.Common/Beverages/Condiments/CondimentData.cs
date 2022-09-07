using System.Collections.Immutable;

namespace Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

public sealed class CondimentData
{
    private CondimentData(
        string description,
        decimal smallCost,
        decimal mediumCost,
        decimal largeCost)
    {
        Description = description;
        Cost = new Dictionary<Size, decimal>
        {
            [Size.Small] = smallCost,
            [Size.Medium] = mediumCost,
            [Size.Large] = largeCost
        };
    }

    public static CondimentData SteamedMilk { get; } = new("Steamed Milk", 0.05m, 0.1m, 0.15m);

    public static CondimentData Mocha { get; } = new("Mocha", 0.15m, 0.2m, 0.25m);

    public static CondimentData Soy { get; } = new("Soy", 0.1m, 0.15m, 0.2m);

    public static CondimentData Whip { get; } = new("Whip", 0.05m, 0.1m, 0.15m);

    public static CondimentData Nothing { get; } = new("Nothing, thanks!", 0, 0, 0);

    public static ImmutableList<CondimentData> Values { get; } = new List<CondimentData>
    {
        Nothing,
        SteamedMilk,
        Mocha,
        Soy,
        Whip
    }.ToImmutableList();

    public string Description { get; }

    public IDictionary<Size, decimal> Cost { get; }
}
