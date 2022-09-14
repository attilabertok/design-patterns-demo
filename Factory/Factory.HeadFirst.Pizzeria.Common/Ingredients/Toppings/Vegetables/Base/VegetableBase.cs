using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Vegetables.Base;

public class VegetableBase :
    ITopping
{
    public VegetableBase(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
