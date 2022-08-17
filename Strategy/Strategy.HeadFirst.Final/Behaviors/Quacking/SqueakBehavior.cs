using Strategy.HeadFirst.Final.Behaviors.Quacking.Interface;

namespace Strategy.HeadFirst.Final.Behaviors.Quacking;

public class SqueakBehavior : IQuackBehavior
{
    public string Quack()
    {
        return "<< Squeak! >>";
    }
}
