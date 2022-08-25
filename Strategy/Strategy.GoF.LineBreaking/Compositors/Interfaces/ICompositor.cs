using System.Collections.Immutable;

using Strategy.GoF.LineBreaking.Entities;

namespace Strategy.GoF.LineBreaking.Compositors.Interfaces;

public interface ICompositor
{
    ImmutableList<int> Compose(ImmutableList<CompositionParameters> parameters, int targetLineWidth);
}
