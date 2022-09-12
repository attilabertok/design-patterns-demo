using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;
using Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators.Base;

public abstract class ThrowingShapeDecoratorBase<TSelf> :
    ShapeDecoratorBase<TSelf, ThrowOnCyclePolicy>
{
    protected ThrowingShapeDecoratorBase(IShape shape)
        : base(shape)
    {
    }
}
