using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces.Names;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces;

public class MarinaraSauce :
    SauceBase
{
    public MarinaraSauce()
        : base(Sauce.Marinara)
    {
    }
}
