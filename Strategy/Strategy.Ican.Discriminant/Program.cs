using Strategy.Ican.Discriminant.DiscriminantStrategies;
using Strategy.Ican.Discriminant.EquationPrinters;
using Strategy.Ican.Discriminant.EquationSolvers;

namespace Strategy.Ican.Discriminant
{
    public static class Program
    {
        public static void Main()
        {
            var realSolver = new QuadraticEquationSolver(new RealDiscriminantStrategy());
            var complexSolver = new QuadraticEquationSolver(new OrdinaryDiscriminantStrategy());
            Console.WriteLine(Printer.Format(1, -1, -6));
            Console.WriteLine($"Real solution: {realSolver.Solve(1, -1, -6)}");
            Console.WriteLine($"Complex solution: {complexSolver.Solve(1, -1, -6)}");
            Console.WriteLine();

            Console.WriteLine(Printer.Format(1, -4, 4));
            Console.WriteLine($"Real solution: {realSolver.Solve(1, -4, 4)}");
            Console.WriteLine($"Complex solution: {complexSolver.Solve(1, -4, 4)}");
            Console.WriteLine();

            Console.WriteLine(Printer.Format(1, 0, 4));
            Console.WriteLine($"Real solution: {realSolver.Solve(1, 0, 4)}");
            Console.WriteLine($"Complex solution: {complexSolver.Solve(1, 0, 4)}");
            Console.WriteLine();
        }
    }
}
