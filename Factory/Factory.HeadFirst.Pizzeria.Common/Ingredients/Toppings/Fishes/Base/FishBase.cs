using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Fishes.Base;

public abstract class FishBase :
    ITopping
{
    protected FishBase(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
