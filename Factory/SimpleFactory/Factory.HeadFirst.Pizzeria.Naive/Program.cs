using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Names;
using Factory.HeadFirst.Pizzeria.Naive.Stores;

namespace Factory.HeadFirst.Pizzeria.Naive
{
    public static class Program
    {
        public static void Main()
        {
            var newYorkPizzaStore = new PizzaStore(PizzaStyle.NewYork);
            newYorkPizzaStore.OrderPizza(PizzaType.Pepperoni);

            Console.WriteLine();

            var chicagoPizzaStore = new PizzaStore(PizzaStyle.Chicago);
            chicagoPizzaStore.OrderPizza(PizzaType.Veggie);
        }
    }
}
