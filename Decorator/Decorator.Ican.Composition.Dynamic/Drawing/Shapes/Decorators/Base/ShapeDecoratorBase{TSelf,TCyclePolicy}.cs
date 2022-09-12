using Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Interfaces;
using Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Drawing.Shapes.Decorators.Base;

public abstract class ShapeDecoratorBase<TSelf, TCyclePolicy> :
    ShapeDecoratorBase
    where TCyclePolicy : IDecoratorCyclePolicy, new()
{
    protected ShapeDecoratorBase(IShape shape)
        : base(shape)
    {
        var type = typeof(TSelf);
        if (Policy.CanAddType(type, Types))
        {
            Types.Add(type);
        }
    }

    protected TCyclePolicy Policy { get; } = new();

    public bool CanApplyPolicy()
    {
        return Policy.CanApply(Types.Last(), Types.SkipLast(1).ToList());
    }
}
