using Strategy.HeadFirst.Naive.Ducks.Base;

namespace Strategy.HeadFirst.Naive.Ducks;

// BUG: fly not overridden, this rubber duck flies
public class RubberDuck : DuckBase
{
    public override string Display()
    {
        return "Cute, and yellow, and rubbery, and helps you debug your code!";
    }

    public override string Quack()
    {
        return "<< Squeak! >>";
    }
}
