using Strategy.Ican.Discriminant.DiscriminantStrategies.Interfaces;

namespace Strategy.Ican.Discriminant.DiscriminantStrategies;

public class RealDiscriminantStrategy : IDiscriminantStrategy
{
    public double CalculateDiscriminant(double a, double b, double c)
    {
        var discriminant = (b * b) - (4 * a * c);

        return discriminant > 0
            ? discriminant
            : double.NaN;
    }
}
