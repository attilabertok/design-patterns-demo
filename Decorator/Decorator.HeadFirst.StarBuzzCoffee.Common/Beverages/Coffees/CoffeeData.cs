namespace Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;

public sealed class CoffeeData
{
    private CoffeeData(string description, decimal baseCost)
    {
        Description = description;
        BaseCost = baseCost;
    }

    public static CoffeeData DarkRoast { get; } = new("Most Excellent Dark Roast", 0.99m);

    public static CoffeeData Decaf { get; } = new("Coffee, but without the ooomph", 1.05m);

    public static CoffeeData Espresso { get; } = new("Espresso", 1.99m);

    public static CoffeeData HouseBlend { get; } = new("House Blend Coffee", 0.89m);

    public string Description { get; }

    public decimal BaseCost { get; }
}
