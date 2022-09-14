namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Sauces.Base;

public class SauceBase
{
    public SauceBase(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
