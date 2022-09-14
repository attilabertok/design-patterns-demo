using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Cheeses.Base;

public class CheeseBase :
    ITopping
{
    public CheeseBase(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
