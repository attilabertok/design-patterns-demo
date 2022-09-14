using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Meats.Base;

public class MeatBase :
    ITopping
{
    public MeatBase(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
