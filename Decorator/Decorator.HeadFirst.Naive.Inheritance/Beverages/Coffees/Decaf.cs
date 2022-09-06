using Decorator.HeadFirst.Naive.Inheritance.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Coffees;

namespace Decorator.HeadFirst.Naive.Inheritance.Beverages.Coffees;

public class Decaf :
    BeverageBase
{
    public Decaf()
    {
        Description = CoffeeData.Decaf.Description;
    }

    public override decimal CalculateCost()
    {
        return CoffeeData.Decaf.BaseCost;
    }
}
