using Decorator.Ican.MultipleInheritance.Interfaces.Creatures.Interfaces;

namespace Decorator.Ican.MultipleInheritance.Interfaces.Creatures;

public class Lizard : ILizard
{
    public Lizard(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public int Age { get; set; }

    public int Weight { get; set; }

    public void Crawl()
    {
        Console.WriteLine($"{Name} is a {GetType().Name} aged {Age}, weighing {Weight} kgs. Look at them crawling in the dirt!");
    }
}
