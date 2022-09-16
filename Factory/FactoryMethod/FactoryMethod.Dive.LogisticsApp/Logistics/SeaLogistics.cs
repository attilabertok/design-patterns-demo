using Bogus;
using FactoryMethod.Dive.LogisticsApp.Logistics.Base;
using FactoryMethod.Dive.LogisticsApp.Transport;
using FactoryMethod.Dive.LogisticsApp.Transport.Extensions;
using FactoryMethod.Dive.LogisticsApp.Transport.Interfaces;

namespace FactoryMethod.Dive.LogisticsApp.Logistics;

public class SeaLogistics :
    LogisticsBase
{
    private readonly List<Ship> ships = new();

    public SeaLogistics(string homePort, IEnumerable<string> goodsTypes)
    {
        var faker = new Faker();

        foreach (var goods in goodsTypes)
        {
            ships.AddRange(Enumerable.Range(0, faker.Random.Int(1, 5)).Select(_ => new Ship(5 * faker.Random.Int(5, 15), goods, homePort)));
        }
    }

    protected override ITransport CreateTransport(string goods, int tonnage, string location)
    {
        var availableShip = ships.FirstOrDefault(ship => ship.IsAvailable(goods, tonnage));

        return availableShip ?? throw new InvalidOperationException("No available ships, try road logistics.");
    }
}
