namespace Factory.HeadFirst.Pizzeria.Common.Ingredients.Doughs.Base;

public abstract class DoughBase
{
    protected DoughBase(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
