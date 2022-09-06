using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Coffees;

public class Decaf :
    BeverageBase
{
    private const decimal BaseCost = 1.05m;
    private const string BaseDescription = "Coffee, but without the ooomph";

    public Decaf()
    {
        Description = BaseDescription;
    }

    public override decimal CalculateCost()
    {
        return BaseCost;
    }
}
