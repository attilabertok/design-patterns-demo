using System.Collections.Immutable;

namespace Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;

public sealed class CoffeeData
{
    private CoffeeData(
        string description,
        decimal baseCostSmall,
        decimal baseCostMedium,
        decimal baseCostLarge)
    {
        Description = description;
        BaseCost = new Dictionary<Size, decimal>
        {
            [Size.Small] = baseCostSmall,
            [Size.Medium] = baseCostMedium,
            [Size.Large] = baseCostLarge
        };
    }

    public static CoffeeData DarkRoast { get; } = new("Most Excellent Dark Roast", 0.75m, 0.99m, 1.59m);

    public static CoffeeData Decaf { get; } = new("Coffee, but without the ooomph", 0.85m, 1.05m, 1.79m);

    public static CoffeeData Espresso { get; } = new("Espresso", 1.25m, 1.99m, 3.49m);

    public static CoffeeData HouseBlend { get; } = new("House Blend Coffee", 0.59m, 0.89m, 1.49m);

    public static ImmutableList<CoffeeData> Values { get; } = new List<CoffeeData>
    {
        DarkRoast,
        Decaf,
        Espresso,
        HouseBlend
    }.ToImmutableList();

    public string Description { get; }

    public IDictionary<Size, decimal> BaseCost { get; }
}
