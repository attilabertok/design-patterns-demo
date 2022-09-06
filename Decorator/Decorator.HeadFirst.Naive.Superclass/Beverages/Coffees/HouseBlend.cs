using Decorator.HeadFirst.Naive.Superclass.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Common.Coffees;

namespace Decorator.HeadFirst.Naive.Superclass.Beverages.Coffees;

public class HouseBlend :
    BeverageBase
{
    public HouseBlend()
    {
        Description = CoffeeData.HouseBlend.Description;
    }

    protected override decimal BaseCost => CoffeeData.HouseBlend.BaseCost;

    public override decimal CalculateCost()
    {
        return BaseCost + base.CalculateCost();
    }
}
