using Strategy.HeadFirst.Naive.Ducks.Base;

namespace Strategy.HeadFirst.Naive.Ducks;

// added recently
// notice the amount of overridden methods
public class DecoyDuck : DuckBase
{
    public override string Display()
    {
        return "Looking like a piece of wood roughly shaped like a duck.";
    }

    public override string Swim()
    {
        return "Floating on the water like wood... or a witch?!";
    }

    public override string Quack()
    {
        return "<< Silence... >>";
    }

    public override string Fly()
    {
        return "Falling like a rock.";
    }
}
