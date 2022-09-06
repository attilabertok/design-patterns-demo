namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;

public interface IBeverage
{
    string Description { get; }

    decimal CalculateCost();
}
