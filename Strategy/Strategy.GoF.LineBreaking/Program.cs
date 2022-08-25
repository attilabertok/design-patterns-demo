using System.Collections.Immutable;

using Strategy.GoF.LineBreaking.Compositors;
using Strategy.GoF.LineBreaking.Entities;
using Strategy.GoF.LineBreaking.Factories;

namespace Strategy.GoF.LineBreaking
{
    public static class Program
    {
        public static void Main()
        {
            const int targetLineWidth = 100;

            var document = DocumentFactory.Create(100).ToList();
            Console.WriteLine($"Document total length: {document.Sum(e => e.NaturalSize.X)}");
            Console.WriteLine($"Target line width: {targetLineWidth}");

            var strategies = new Dictionary<string, Composition>
            {
                ["Array"] = new(new ArrayCompositor()),
                ["Simple"] = new(new SimpleCompositor()),
                ["Average"] = new(new AverageCompositor())
            }.ToImmutableDictionary();

            foreach (var strategy in strategies)
            {
                Console.WriteLine($"==== {strategy.Key} strategy ====");
                var lineBreaks = strategy.Value.Repair(document, targetLineWidth);
                DisplayResult(document, lineBreaks);
                Console.WriteLine();
            }
        }

        private static void DisplayResult(
            IReadOnlyCollection<CompositionParameters> document,
            ImmutableList<int> lineBreaks)
        {
            for (var index = 0; index <= lineBreaks.Count; index++)
            {
                var lineBreakIndex = index < lineBreaks.Count
                    ? lineBreaks[index]
                    : document.Count;
                var previousLineBreakIndex = index > 0
                    ? lineBreaks[index - 1]
                    : -1;
                var lineLength = document.Skip(previousLineBreakIndex + 1)
                    .Take(lineBreakIndex - previousLineBreakIndex)
                    .Sum(e => e.NaturalSize.X);
                Console.WriteLine($"Line {index + 1} length: {lineLength}");
            }
        }
    }
}
