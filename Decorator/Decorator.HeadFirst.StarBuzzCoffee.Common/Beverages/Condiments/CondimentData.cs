namespace Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

public sealed class CondimentData
{
    private CondimentData(string description, decimal cost)
    {
        Description = description;
        Cost = cost;
    }

    public static CondimentData SteamedMilk { get; } = new("Steamed Milk", 0.1m);

    public static CondimentData Mocha { get; } = new("Mocha", 0.2m);

    public static CondimentData Soy { get; } = new("Soy", 0.15m);

    public static CondimentData Whip { get; } = new("Whip", 0.1m);

    public static CondimentData Nothing { get; } = new("Nothing, thanks!", 0);

    public string Description { get; }

    public decimal Cost { get; }
}
