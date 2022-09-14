using Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;
using Factory.HeadFirst.Pizzeria.SimpleFactory.Pizzas.Factories.Interfaces;

namespace Factory.HeadFirst.Pizzeria.SimpleFactory.Stores;

public class PizzaStore
{
    private readonly IPizzaFactory pizzaFactory;

    public PizzaStore(IPizzaFactory pizzaFactory)
    {
        this.pizzaFactory = pizzaFactory;
    }

    /// <remarks>
    /// Pizza creation responsibility is delegated to the PizzaFactory that can be modified independently from the store (i.e., the client)
    /// </remarks>
    public PizzaBase OrderPizza(string type)
    {
        var pizza = pizzaFactory.CreatePizza(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
