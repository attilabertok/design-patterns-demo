using Factory.HeadFirst.Pizzeria.Common.Pizzas.Base;

namespace Factory.HeadFirst.Pizzeria.SimpleFactory.Pizzas.Factories.Interfaces;

public interface IPizzaFactory
{
    PizzaBase CreatePizza(string type);
}
