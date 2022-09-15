using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Names;
using Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories.Interfaces;

namespace Factory.HeadFirst.Pizzeria.Factories.Pizzas.Base;

/// <remarks>
/// The style-based parallel inheritance hierarchies are no longer necessary.
/// </remarks>
public class PizzaBase
{
    private readonly string style;
    private readonly DoughBase dough;
    private readonly SauceBase sauce;

    protected PizzaBase(
        string style,
        string name,
        IPizzaIngredientFactory ingredientFactory)
    {
        this.style = style;
        Name = $"{style} style {name} pizza";
        IngredientFactory = ingredientFactory ?? throw new ArgumentNullException(nameof(ingredientFactory));
        dough = ingredientFactory.CreateDough();
        sauce = ingredientFactory.CreateSauce();
        Toppings = new List<ITopping> { ingredientFactory.CreateCheese() }.ToImmutableList();
    }

    public string Name { get; }

    protected IPizzaIngredientFactory IngredientFactory { get; }

    protected ImmutableList<ITopping> Toppings { get; set; }

    public virtual void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350 degrees.");
    }

    public virtual void Box()
    {
        Console.WriteLine("Placing the pizza in official PizzaStore box.");
    }

    /// <remarks>
    /// This should probably be a Strategy, based on the style.
    /// </remarks>
    public virtual void Cut()
    {
        switch (style)
        {
            case PizzaStyle.Chicago:
                Console.WriteLine("Cutting the pizza into square slices.");
                break;
            case PizzaStyle.NewYork:
                Console.WriteLine("Cutting the pizza into diagonal slices.");
                break;
            default:
                Console.WriteLine("Cutting the pizza into diagonal slices.");
                break;
        }
    }

    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {Name}:");
        Console.WriteLine($"Tossing {dough.Name}...");
        Console.WriteLine($"Adding {sauce.Name}...");
        Console.WriteLine("Adding toppings:");
        foreach (var topping in Toppings)
        {
            Console.WriteLine($"  * {topping.Name}");
        }
    }
}
