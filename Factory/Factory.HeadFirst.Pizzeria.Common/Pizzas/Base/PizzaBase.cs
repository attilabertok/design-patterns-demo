using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;

public abstract class PizzaBase
{
    private readonly DoughBase dough;
    private readonly SauceBase sauce;
    private readonly ImmutableList<ITopping> toppings;

    protected PizzaBase(
        string name,
        DoughBase dough,
        SauceBase sauce,
        ImmutableList<ITopping> toppings)
    {
        Name = $"{name} pizza";
        this.dough = dough;
        this.sauce = sauce;
        this.toppings = toppings;
    }

    public string Name { get; }

    public virtual void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350 degrees.");
    }

    public virtual void Box()
    {
        Console.WriteLine("Placing the pizza in official PizzaStore box.");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices.");
    }

    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {Name}:");
        Console.WriteLine($"Tossing {dough.Name}...");
        Console.WriteLine($"Adding {sauce.Name}...");
        Console.WriteLine("Adding toppings:");
        foreach (var topping in toppings)
        {
            Console.WriteLine($"  * {topping.Name}");
        }
    }
}
