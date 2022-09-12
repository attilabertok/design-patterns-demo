using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;
using Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators.Base;

public abstract class AllowingShapeDecoratorBase<TSelf> :
    ShapeDecoratorBase<TSelf, AllowCyclesPolicy>
{
    protected AllowingShapeDecoratorBase(IShape shape)
        : base(shape)
    {
    }
}
