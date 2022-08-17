using Strategy.HeadFirst.Final.Behaviors.Quacking.Interface;

namespace Strategy.HeadFirst.Final.Behaviors.Quacking;

public class MuteQuackBehavior : IQuackBehavior
{
    public string Quack()
    {
        return "<< Silence... >>";
    }
}
