using Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies;

public class ThrowOnCyclePolicy :
    IDecoratorCyclePolicy
{
    public bool CanAddType(Type type, IList<Type> allTypes)
    {
        Handle(type, allTypes);

        return true;
    }

    public bool CanApply(Type type, IList<Type> allTypes)
    {
        Handle(type, allTypes);

        return true;
    }

    private static void Handle(Type type, ICollection<Type> allTypes)
    {
        if (allTypes.Contains(type))
        {
            throw new InvalidOperationException($"Cycle detected for {type.Name}");
        }
    }
}
