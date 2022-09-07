using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Infrastructure;

namespace Decorator.HeadFirst.StarBuzzCoffee.Infrastructure;

public static class BeverageExtensions
{
    public static CostRange CalculateCostRange(this IBeverage beverage)
    {
        var minCost = beverage.CalculateCost(Size.Small);
        var maxCost = beverage.CalculateCost(Size.Large);

        return new CostRange(minCost, maxCost);
    }
}
