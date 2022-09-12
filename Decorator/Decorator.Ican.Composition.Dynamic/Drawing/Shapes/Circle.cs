using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes;

public class Circle : IShape
{
    public Circle(decimal radius)
    {
        Radius = radius;
    }

    public decimal Radius { get; private set; }

    public string Draw() => $"a circle with a radius of {Radius}";

    public void Resize(decimal factor) => Radius *= factor;
}
