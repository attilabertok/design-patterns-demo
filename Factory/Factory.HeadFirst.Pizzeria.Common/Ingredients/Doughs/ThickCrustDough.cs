using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs.Base;
using Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs.Names;

namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs;

public class ThickCrustDough :
    DoughBase
{
    public ThickCrustDough()
        : base(Dough.ThickCrust)
    {
    }
}
