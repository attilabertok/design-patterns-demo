using System.Text;

using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators.Base;
using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators;

public class ColoredShape :
    ThrowingShapeDecoratorBase<ColoredShape>
{
    private readonly IShape shape;

    public ColoredShape(IShape shape, string color)
        : base(shape)
    {
        this.shape = shape;
        Color = color;
    }

    public string Color { get; set; }

    public override string Draw()
    {
        var sb = new StringBuilder(Shape.Draw());

        if (CanApplyPolicy())
        {
            sb.Append($" colored {Color}");
        }

        return sb.ToString();
    }

    public override void Resize(decimal factor)
    {
        shape.Resize(factor);
    }
}
