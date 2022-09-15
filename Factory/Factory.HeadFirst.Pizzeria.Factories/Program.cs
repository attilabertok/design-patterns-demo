using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Factories.Stores;

namespace Factory.HeadFirst.Pizzeria.Factories
{
    public static class Program
    {
        public static void Main()
        {
            var newYorkPizzaStore = new NewYorkPizzaStore();
            newYorkPizzaStore.OrderPizza(PizzaType.Pepperoni);

            Console.WriteLine();

            var chicagoPizzaStore = new ChicagoPizzaStore();
            chicagoPizzaStore.OrderPizza(PizzaType.Veggie);
        }
    }
}
