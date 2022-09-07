using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Condiments;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;

public abstract class BeverageBase
{
    protected BeverageBase()
    {
        Description = "Unknown beverage";
        Size = Size.Small;
        Condiments = new List<CondimentData>();
    }

    public CoffeeData? CoffeeData { get; protected set; }

    public IList<CondimentData> Condiments { get; }

    public string Description { get; protected set; }

    public Size Size { get; set; }

    public abstract decimal CalculateCost(Size? size = null);
}
