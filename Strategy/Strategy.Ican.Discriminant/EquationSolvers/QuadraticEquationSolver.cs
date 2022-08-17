using System.Numerics;

using Strategy.Ican.Discriminant.DiscriminantStrategies.Interfaces;

namespace Strategy.Ican.Discriminant.EquationSolvers;

public class QuadraticEquationSolver
{
    private readonly IDiscriminantStrategy discriminantStrategy;

    public QuadraticEquationSolver(IDiscriminantStrategy discriminantStrategy)
    {
        this.discriminantStrategy = discriminantStrategy;
    }

    public (Complex PlusSolution, Complex MinusSolution) Solve(double a, double b, double c)
    {
        if (a == 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a), a, "Quadratic part must not be 0");
        }

        var discriminant = discriminantStrategy.CalculateDiscriminant(a, b, c);

        var plusResult = (-b + Complex.Sqrt(discriminant)) / (2 * a);
        var minusResult = (-b - Complex.Sqrt(discriminant)) / (2 * a);

        return (plusResult, minusResult);
    }
}
