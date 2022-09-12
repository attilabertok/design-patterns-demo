using System.Text;

using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators.Base;
using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators;

public class TransparentShape :
    AllowingShapeDecoratorBase<TransparentShape>
{
    private readonly IShape shape;

    public TransparentShape(IShape shape, decimal transparency)
        : base(shape)
    {
        this.shape = shape;
        Transparency = transparency;
    }

    public decimal Transparency { get; set; }

    public override string Draw()
    {
        var sb = new StringBuilder(Shape.Draw());

        if (CanApplyPolicy())
        {
            sb.Append($" with a transparency of {Transparency * 100}%");
        }

        return sb.ToString();
    }

    public override void Resize(decimal factor) => shape.Resize(factor);
}
