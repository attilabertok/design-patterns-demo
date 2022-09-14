using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Names;
using Factory.HeadFirst.Pizzeria.SimpleFactory.Pizzas.Factories;
using Factory.HeadFirst.Pizzeria.SimpleFactory.Stores;

namespace Factory.HeadFirst.Pizzeria.SimpleFactory
{
    public static class Program
    {
        public static void Main()
        {
            var newYorkPizzaFactory = new PizzaFactory(PizzaStyle.NewYork);
            var newYorkPizzaStore = new PizzaStore(newYorkPizzaFactory);
            newYorkPizzaStore.OrderPizza(PizzaType.Pepperoni);

            Console.WriteLine();

            var chicagoPizzaFactory = new PizzaFactory(PizzaStyle.Chicago);
            var chicagoPizzaStore = new PizzaStore(chicagoPizzaFactory);
            chicagoPizzaStore.OrderPizza(PizzaType.Veggie);
        }
    }
}
