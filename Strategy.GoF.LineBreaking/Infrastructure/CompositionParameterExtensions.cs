using System.Collections.Immutable;

using Strategy.GoF.LineBreaking.Entities;

namespace Strategy.GoF.LineBreaking.Infrastructure;

public static class CompositionParameterExtensions
{
    public static bool HasItemAfter(this ImmutableList<CompositionParameters> instance, int index)
    {
        return instance.Count > index;
    }
}
