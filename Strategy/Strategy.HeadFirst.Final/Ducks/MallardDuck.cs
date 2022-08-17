using Strategy.HeadFirst.Final.Behaviors.Flying;
using Strategy.HeadFirst.Final.Behaviors.Quacking;
using Strategy.HeadFirst.Final.Ducks.Base;

namespace Strategy.HeadFirst.Final.Ducks;

public class MallardDuck : DuckBase
{
    public MallardDuck()
        : base(new QuackBehavior(), new FlyBehavior())
    {
    }

    public override string Display()
    {
        return "Looking like a mallard...";
    }
}
