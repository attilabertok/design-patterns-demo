using System.Collections.Immutable;

using Factory.HeadFirst.Pizzeria.Common.Ingredients.Toppings.Interfaces;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Names;
using Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago.Base;

namespace Factory.HeadFirst.Pizzeria.Common.Pizzas.Styles.Chicago
{
    public class ChicagoStyleCheesePizza
        : ChicagoStylePizzaBase
    {
        public ChicagoStyleCheesePizza()
            : base(
                PizzaType.Cheese,
                ImmutableList<ITopping>.Empty)
        {
        }
    }
}
