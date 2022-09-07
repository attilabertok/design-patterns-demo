using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Infrastructure;

namespace Decorator.HeadFirst.Naive.Inheritance.Infrastructure;

public static class BeverageExtensions
{
    public static CostRange CalculateCostRange(this BeverageBase beverage)
    {
        var minCost = beverage.CoffeeData?.BaseCost.Values.Min() ?? 0;
        var maxCost = beverage.CoffeeData?.BaseCost.Values.Max() ?? 0;
        foreach (var condiment in beverage.Condiments)
        {
            minCost += condiment.Cost.Values.Min();
            maxCost += condiment.Cost.Values.Max();
        }

        return new CostRange(minCost, maxCost);
    }
}
