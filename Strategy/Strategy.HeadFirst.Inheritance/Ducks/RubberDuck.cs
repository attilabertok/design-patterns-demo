using Strategy.HeadFirst.Inheritance.Behaviors;
using Strategy.HeadFirst.Inheritance.Ducks.Base;

namespace Strategy.HeadFirst.Inheritance.Ducks;

public class RubberDuck : DuckBase, IQuackable
{
    public override string Display()
    {
        return "Cute, and yellow, and rubbery, and helps you debug your code!";
    }

    public string Quack()
    {
        return "<< Squeak! >>";
    }
}
