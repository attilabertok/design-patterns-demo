using Strategy.HeadFirst.Final.Behaviors.Flying;
using Strategy.HeadFirst.Final.Behaviors.Quacking;
using Strategy.HeadFirst.Final.Ducks.Base;

namespace Strategy.HeadFirst.Final.Ducks;

// BUG: fly not overridden, this rubber duck flies
public class RubberDuck : DuckBase
{
    public RubberDuck()
        : base(new SqueakBehavior(), new FlyDisabledBehavior())
    {
    }

    public override string Display()
    {
        return "Cute, and yellow, and rubbery, and helps you debug your code!";
    }
}
