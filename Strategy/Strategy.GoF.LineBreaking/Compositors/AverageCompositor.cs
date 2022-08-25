using System.Collections.Immutable;

using Strategy.GoF.LineBreaking.Compositors.Interfaces;
using Strategy.GoF.LineBreaking.Entities;
using Strategy.GoF.LineBreaking.Infrastructure;

namespace Strategy.GoF.LineBreaking.Compositors;

public class AverageCompositor : ICompositor
{
    public ImmutableList<int> Compose(ImmutableList<CompositionParameters> parameters, int targetLineWidth)
    {
        var totalWidth = parameters.Sum(p => p.NaturalSize.X);
        var expectedLineCount = Convert.ToInt32(Math.Ceiling(totalWidth / targetLineWidth));
        var expectedLineWidth = Convert.ToInt32(Math.Floor(totalWidth / expectedLineCount));

        var result = new List<int>();
        var elementIndex = 0;

        var line = new Line(expectedLineWidth);
        while (parameters.HasItemAfter(elementIndex))
        {
            if (line.HasFreeSpace())
            {
                var nextElementWidth = parameters[elementIndex].NaturalSize.X;
                if (!line.CanFitElement(nextElementWidth))
                {
                    result.Add(elementIndex - 1);
                    line = new Line(expectedLineWidth);
                }

                line.AddElement(nextElementWidth);
                elementIndex++;
            }
            else
            {
                result.Add(elementIndex - 1);
                line = new Line(expectedLineWidth);
            }
        }

        return result.ToImmutableList();
    }
}
