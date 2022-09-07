using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments.Base;

public abstract class CondimentDecoratorBase :
    IBeverage
{
    protected CondimentDecoratorBase(IBeverage beverage)
    {
        Beverage = beverage;
        Description = $"{beverage.Description} and ";
    }

    public string Description { get; protected set; }

    public Size Size
    {
        get => Beverage.Size;
        set => Beverage.Size = value;
    }

    protected CondimentData? CondimentData { get; set; }

    protected IBeverage Beverage { get; }

    public decimal CalculateCost(Size? size = null)
    {
        size ??= Size;

        var condimentCost = CondimentData?.Cost[size] ?? 0;

        return Beverage.CalculateCost() + condimentCost;
    }
}
