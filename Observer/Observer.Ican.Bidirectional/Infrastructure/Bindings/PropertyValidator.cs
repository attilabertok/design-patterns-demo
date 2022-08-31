using System.Reflection;

namespace Observer.Ican.Bidirectional.Infrastructure.Bindings;

public static class PropertyValidator
{
    public static bool IsValid(PropertyInfo? sourceExpression)
    {
        return sourceExpression is not null;
    }
}
