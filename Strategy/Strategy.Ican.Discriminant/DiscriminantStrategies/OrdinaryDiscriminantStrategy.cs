using Strategy.Ican.Discriminant.DiscriminantStrategies.Interfaces;

namespace Strategy.Ican.Discriminant.DiscriminantStrategies;

public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
{
    public double CalculateDiscriminant(double a, double b, double c)
    {
        return (b * b) - (4 * a * c);
    }
}
