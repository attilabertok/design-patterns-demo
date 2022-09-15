using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Factories.Ingredients.Factories.Interfaces;
using Factory.HeadFirst.Pizzeria.Factories.Pizzas;
using Factory.HeadFirst.Pizzeria.Factories.Pizzas.Base;

namespace Factory.HeadFirst.Pizzeria.Factories.Stores.Base;

public abstract class PizzaStoreBase
{
    private readonly string style;

    protected PizzaStoreBase(string style, IPizzaIngredientFactory ingredientFactory)
    {
        this.style = style;
        IngredientFactory = ingredientFactory;
    }

    protected IPizzaIngredientFactory IngredientFactory { get; }

    /// <remarks>
    /// Pizza creation responsibility is delegated to the subclasses that can be modified independently from the store (i.e., the client)
    /// </remarks>
    public PizzaBase OrderPizza(string type)
    {
        var pizza = CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    /// <summary>
    /// The factory method to which product creation is delegated to.
    /// This could be different for subclasses and can be abstract/virtual here and implemented/overridden in the subclasses.
    /// </summary>
    /// <param name="type">The type of product to create.</param>
    /// <returns>The product.</returns>
    protected PizzaBase CreatePizza(string type)
    {
        return type switch
        {
            PizzaType.Cheese => new CheesePizza(style, IngredientFactory),
            PizzaType.Pepperoni => new PepperoniPizza(style, IngredientFactory),
            PizzaType.Clam => new ClamPizza(style, IngredientFactory),
            PizzaType.Veggie => new VeggiePizza(style, IngredientFactory),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, "Unknown pizza type"),
        };
    }
}
