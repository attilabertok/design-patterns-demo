using Strategy.HeadFirst.Final.Behaviors.Flying.Interface;

namespace Strategy.HeadFirst.Final.Behaviors.Flying;

public class FlyDisabledBehavior : IFlyBehavior
{
    public string Fly()
    {
        return "Cannot fly. :(";
    }
}
