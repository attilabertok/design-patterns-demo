using Decorator.Ican.MultipleInheritance.Interfaces.Creatures.Interfaces;

namespace Decorator.Ican.MultipleInheritance.Interfaces.Creatures;

public class Dragon : IBird, ILizard
{
    private readonly IBird birdImplementation;
    private readonly ILizard lizardImplementation;
    private int weight;

    public Dragon(string name)
    {
        birdImplementation = new Bird(name);
        lizardImplementation = new Lizard(name);
    }

    /// <remarks>
    /// Sort of okay-ish, readonly, will contain the same for both, will not change.
    /// </remarks>
    public string Name => birdImplementation.Name;

    /// <remarks>
    /// Incorrect, does not set Age property of the two implementations.
    /// </remarks>
    public int Age { get; set; }

    /// <remarks>
    /// This is the correct (but somewhat uncomfortable) implementation.
    /// </remarks>
    public int Weight
    {
        get => weight;
        set
        {
            weight = value;
            lizardImplementation.Weight = value;
            birdImplementation.Weight = value;
        }
    }

    /// <remarks>
    /// Note that the type name (implemented as GetType().Name) will be "incorrect":
    /// the type implementing Crawl is still a lizard, not a dragon.
    /// </remarks>
    public void Crawl()
    {
        lizardImplementation.Crawl();
    }

    /// <remarks>
    /// Note that the type name (implemented as nameof(Bird)) will be "incorrect":
    /// the type implementing Fly is still a bird, not a dragon.
    /// </remarks>
    public void Fly()
    {
        birdImplementation.Fly();
    }
}
