using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;

public class Espresso :
    BeverageBase
{
    private const decimal BaseCost = 1.99m;
    private const string BaseDescription = "Espresso";

    public Espresso()
    {
        Description = BaseDescription;
    }

    public override decimal CalculateCost()
    {
        return BaseCost;
    }
}
