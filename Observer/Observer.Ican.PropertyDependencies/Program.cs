using Observer.Ican.PropertyDependencies.DependencyManaging;
using Observer.Ican.PropertyDependencies.Naive;

namespace Observer.Ican.PropertyDependencies
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("==== Naive demo ====");
            NaiveDemo.Execute();

            Console.WriteLine();

            Console.WriteLine("==== Dependency managing demo ====");
            DependencyManagingDemo.Execute();
        }
    }
}
