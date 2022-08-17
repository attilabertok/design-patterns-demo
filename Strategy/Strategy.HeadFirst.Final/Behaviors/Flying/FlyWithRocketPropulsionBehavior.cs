using Strategy.HeadFirst.Final.Behaviors.Flying.Interface;

namespace Strategy.HeadFirst.Final.Behaviors.Flying;

public class FlyWithRocketPropulsionBehavior : IFlyBehavior
{
    public string Fly()
    {
        return "Woo-hoo! I'm flying with a rocket attached to my backside!";
    }
}
