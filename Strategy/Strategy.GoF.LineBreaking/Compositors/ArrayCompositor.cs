using System.Collections.Immutable;

using Strategy.GoF.LineBreaking.Compositors.Interfaces;
using Strategy.GoF.LineBreaking.Entities;
using Strategy.GoF.LineBreaking.Infrastructure;

namespace Strategy.GoF.LineBreaking.Compositors;

public class ArrayCompositor : ICompositor
{
    public ImmutableList<int> Compose(ImmutableList<CompositionParameters> parameters, int targetLineWidth)
    {
        var result = new List<int>();
        var elementIndex = 0;

        var line = new Line(targetLineWidth);
        while (parameters.HasItemAfter(elementIndex))
        {
            if (line.HasFreeSpace())
            {
                var nextElementWidth = parameters[elementIndex].NaturalSize.X;
                line.AddElement(nextElementWidth);

                elementIndex++;
            }
            else
            {
                result.Add(elementIndex - 1);
                line = new Line(targetLineWidth);
            }
        }

        return result.ToImmutableList();
    }
}
