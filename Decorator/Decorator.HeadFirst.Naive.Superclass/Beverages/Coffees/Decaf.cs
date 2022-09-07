using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Beverages.Coffees;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class Decaf :
    BeverageBase
{
    public Decaf()
    {
        Description = CoffeeData.Decaf.Description;
    }

    protected override decimal BaseCost => CoffeeData.Decaf.BaseCost;

    public override decimal CalculateCost()
    {
        return BaseCost + base.CalculateCost();
    }
}
