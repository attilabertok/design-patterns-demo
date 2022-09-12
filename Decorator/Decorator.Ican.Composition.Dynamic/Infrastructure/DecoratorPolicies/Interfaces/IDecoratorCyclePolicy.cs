namespace Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies.Interfaces;

public interface IDecoratorCyclePolicy
{
    bool CanAddType(Type type, IList<Type> allTypes);

    bool CanApply(Type type, IList<Type> allTypes);
}
