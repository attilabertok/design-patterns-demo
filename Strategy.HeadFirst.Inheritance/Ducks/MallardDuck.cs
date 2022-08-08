using Strategy.HeadFirst.Inheritance.Behaviors;
using Strategy.HeadFirst.Inheritance.Ducks.Base;

namespace Strategy.HeadFirst.Inheritance.Ducks;

public class MallardDuck : DuckBase, IFlyable, IQuackable
{
    public override string Display()
    {
        return "Looking like a mallard...";
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
