namespace Observer.Ican.Bidirectional
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("==== Naive implementation ====");
            NaiveImplementation.Demo();

            Console.WriteLine("==== Implementation with binding ====");
            BindingImplementation.Demo();
        }
    }
}
