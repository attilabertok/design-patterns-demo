using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes;

public class Square : IShape
{
    public Square(decimal side)
    {
        Side = side;
    }

    public decimal Side { get; private set; }

    public string Draw() => $"a square with a side length of {Side}";

    public void Resize(decimal factor) => Side *= factor;
}
