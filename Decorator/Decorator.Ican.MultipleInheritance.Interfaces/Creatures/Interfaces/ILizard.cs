namespace Decorator.Ican.MultipleInheritance.Interfaces.Creatures.Interfaces;

public interface ILizard
{
    string Name { get; }

    int Age { get; set; }

    int Weight { get; set; }

    void Crawl();
}
