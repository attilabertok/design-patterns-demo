using Bogus;
using Strategy.GoF.LineBreaking.Entities;

namespace Strategy.GoF.LineBreaking.Factories;

public class DocumentFactory
{
    public static IEnumerable<CompositionParameters> Create(int itemCount)
    {
        return Enumerable.Range(1, itemCount)
            .Select(_ => CreateItem())
            .ToList();
    }

    private static CompositionParameters CreateItem()
    {
        var faker = new Faker();

        Scale naturalSize = new(Math.Round(faker.Random.Decimal(1, 8)), Math.Round(faker.Random.Decimal(1)));
        Scale stretchability = new(faker.Random.Decimal(1.25M, 4), Math.Round(faker.Random.Decimal(1)));
        Scale shrinkability = new(faker.Random.Decimal(0.1M), faker.Random.Decimal(8));

        return new CompositionParameters(naturalSize, stretchability, shrinkability);
    }
}
