using Decorator.Ican.MultipleInheritance.Interfaces.Creatures.Interfaces;

namespace Decorator.Ican.MultipleInheritance.Interfaces.Creatures;

public class Bird : IBird
{
    public Bird(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public int Age { get; set; }

    public int Weight { get; set; }

    public void Fly()
    {
        Console.WriteLine($"{Name} is a {nameof(Bird)} aged {Age}, weighing {Weight} kgs. Look at them soaring in the sky!");
    }
}
