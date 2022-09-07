using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;

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

    protected IBeverage Beverage { get; }

    public abstract decimal CalculateCost();
}
