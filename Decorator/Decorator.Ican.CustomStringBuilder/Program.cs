namespace Decorator.Ican.CustomStringBuilder
{
    public static class Program
    {
        public static void Main()
        {
            var cb = new CodeBuilder();

            cb.AppendLine("class foo")
                .AppendLine("{")
                .AppendLine("}");

            Console.WriteLine(cb.ToString());
        }
    }
}
