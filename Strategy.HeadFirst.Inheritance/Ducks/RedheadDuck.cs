using Strategy.HeadFirst.Inheritance.Behaviors;
using Strategy.HeadFirst.Inheritance.Ducks.Base;

namespace Strategy.HeadFirst.Inheritance.Ducks;

public class RedheadDuck : DuckBase, IFlyable, IQuackable
{
    public override string Display()
    {
        return "Looking like a pretty redhead...";
    }

    public string Quack()
    {
        return "<< Quack! >> - quacking like a duck...";
    }

    public string Fly()
    {
        return "Flying like a duck...";
    }
}
