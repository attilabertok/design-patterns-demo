using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators.Base;

public abstract class ShapeDecoratorBase : IShape
{
    protected ShapeDecoratorBase(IShape shape)
    {
        Shape = shape;

        if (shape is ShapeDecoratorBase decorator)
        {
            Types.AddRange(decorator.Types);
        }
    }

    protected internal List<Type> Types { get; } = new();

    protected internal IShape Shape { get; }

    public abstract string Draw();

    public abstract void Resize(decimal factor);
}
