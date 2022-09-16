using FactoryMethod.Dive.LogisticsApp.Logistics.Base;
using FactoryMethod.Dive.LogisticsApp.Transport;
using FactoryMethod.Dive.LogisticsApp.Transport.Extensions;
using FactoryMethod.Dive.LogisticsApp.Transport.Interfaces;

namespace FactoryMethod.Dive.LogisticsApp.Logistics;

public class RoadLogistics :
    LogisticsBase
{
    private readonly string depoLocation;
    private readonly List<Truck> trucks = new();

    public RoadLogistics(string depoLocation)
    {
        this.depoLocation = depoLocation;
    }

    protected override ITransport CreateTransport(string goods, int tonnage, string location)
    {
        var availableTrucks = trucks.Where(truck => truck.IsAvailable(goods, tonnage)).ToList();
        if (availableTrucks.Any())
        {
            return availableTrucks.FirstOrDefault(truck => truck.IsAtLocation(location)) ?? availableTrucks.First();
        }

        var newTruck = new Truck(tonnage, goods, depoLocation);
        trucks.Add(newTruck);

        return newTruck;
    }
}
