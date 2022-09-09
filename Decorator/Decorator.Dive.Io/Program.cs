using Bogus;
using Decorator.Dive.Io.Configuration;
using Decorator.Dive.Io.DataSources;
using Decorator.Dive.Io.Decorators;
using Decorator.Dive.Io.Demos;
using Decorator.Dive.Io.Interfaces;
using Decorator.Dive.Io.SalaryLogging;

namespace Decorator.Dive.Io
{
    public static class Program
    {
        public static void Main()
        {
            ProductReviewDemo.Run();
            Console.WriteLine();
            SalariesDemo.Run();
        }
    }
}
