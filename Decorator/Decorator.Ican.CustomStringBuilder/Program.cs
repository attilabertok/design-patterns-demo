namespace Decorator.Ican.CustomStringBuilder
{
    public static class Program
    {
        public static void Main()
        {
            var cb = new CodeBuilder();
            cb += "class foo" + "{" + "}";

            Console.WriteLine(cb.ToString());
        }
    }
}
