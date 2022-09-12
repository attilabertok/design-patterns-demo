using Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies.Interfaces;

namespace Decorator.Ican.Composition.Dynamic.Infrastructure.DecoratorPolicies;

public class AbsorbCyclesPolicy :
    IDecoratorCyclePolicy
{
    public bool CanAddType(Type type, IList<Type> allTypes)
    {
        if (allTypes.Contains(type))
        {
            Console.WriteLine($"allowing cycles on creation for {type.Name}");
        }

        return true;
    }

    public bool CanApply(Type type, IList<Type> allTypes)
    {
        var isCyclic = allTypes.Contains(type);
        if (isCyclic)
        {
            Console.WriteLine($"absorbing cycles on application for {type.Name}");
        }

        return !isCyclic;
    }
}
