using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;
using Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators.Base;

public abstract class AbsorbingShapeDecoratorBase<TSelf> :
    ShapeDecoratorBase<TSelf, AbsorbCyclesPolicy>
{
    protected AbsorbingShapeDecoratorBase(IShape shape)
        : base(shape)
    {
    }
}
