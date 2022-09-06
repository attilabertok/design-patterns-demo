using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Base;
using Decorator.HeadFirst.StarBuzzCoffee.Beverages.Condiments;

namespace Decorator.HeadFirst.StarBuzzCoffee.Beverages.Factories;

public static class BeverageFactory
{
    public static T Create<T>()
        where T : BeverageBase, new()
    {
        return new T();
    }

    public static SteamedMilk WithSteamedMilk(this IBeverage beverage)
    {
        return new SteamedMilk(beverage);
    }

    public static Mocha WithMocha(this IBeverage beverage)
    {
        return new Mocha(beverage);
    }

    public static Soy WithSoy(this IBeverage beverage)
    {
        return new Soy(beverage);
    }

    public static Whip WithWhip(this IBeverage beverage)
    {
        return new Whip(beverage);
    }
}
