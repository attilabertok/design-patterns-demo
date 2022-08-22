using Strategy.Ican.Common.Formatting;
using Strategy.Ican.Dynamic.TextProcessing;

namespace Strategy.Ican.Dynamic
{
    public static class Program
    {
        public static void Main()
        {
            var textProcessor = new TextProcessor();
            textProcessor.SetOutputFormat(OutputFormat.Markdown);
            textProcessor.AppendList(new[] { "Markdown Item 1", "Markdown Item 2", "Markdown Item 3" });
            Console.WriteLine(textProcessor.Display());
            textProcessor.SetOutputFormat(OutputFormat.Html);
            textProcessor.AppendList(new[] { "Html Item 1", "Html Item 2", "Html Item 3" });
            Console.WriteLine(textProcessor.Display());
        }
    }
}
