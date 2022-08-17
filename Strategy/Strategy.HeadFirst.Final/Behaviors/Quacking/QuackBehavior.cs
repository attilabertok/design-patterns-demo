using Strategy.HeadFirst.Final.Behaviors.Quacking.Interface;

namespace Strategy.HeadFirst.Final.Behaviors.Quacking;

public class QuackBehavior : IQuackBehavior
{
    public string Quack()
    {
        return "<< Quack! >> - quacking like a duck...";
    }
}