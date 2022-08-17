using Strategy.HeadFirst.Final.Behaviors.Flying;
using Strategy.HeadFirst.Final.Behaviors.Quacking;
using Strategy.HeadFirst.Final.Ducks.Base;

namespace Strategy.HeadFirst.Final.Ducks;

// added recently
// notice the amount of overridden methods
public class DecoyDuck : DuckBase
{
    public DecoyDuck()
        : base(new MuteQuackBehavior(), new FlyDisabledBehavior())
    {
    }

    public override string Display()
    {
        return "Looking like a piece of wood roughly shaped like a duck.";
    }

    public override string Swim()
    {
        return "Floating on the water like wood... or a witch?!";
    }

    public void AttachRocket()
    {
        Console.WriteLine("Attaching rocket to decoy duck...");
        FlyBehavior = new FlyWithRocketPropulsionBehavior();
        Console.WriteLine("Rocket successfully attached.");
    }
}
