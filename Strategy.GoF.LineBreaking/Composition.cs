using System.Collections.Immutable;

using Strategy.GoF.LineBreaking.Compositors.Interfaces;
using Strategy.GoF.LineBreaking.Entities;

namespace Strategy.GoF.LineBreaking;

public class Composition
{
    private readonly ICompositor compositor;

    public Composition(ICompositor compositor)
    {
        this.compositor = compositor;
    }

    public ImmutableList<int> Repair(IEnumerable<CompositionParameters> document, int lineWidth)
    {
        return compositor.Compose(document.ToImmutableList(), lineWidth);
    }
}
