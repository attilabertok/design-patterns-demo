using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;

public interface IBeverage
{
    string Description { get; }

    public Size Size { get; set; }

    decimal CalculateCost(Size? size = null);
}
