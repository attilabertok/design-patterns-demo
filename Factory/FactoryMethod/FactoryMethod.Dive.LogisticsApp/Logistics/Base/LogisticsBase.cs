using FactoryMethod.Dive.LogisticsApp.Transport.Interfaces;

namespace FactoryMethod.Dive.LogisticsApp.Logistics.Base;

public abstract class LogisticsBase
{
    public void PlanDelivery(string goods, int tonnage, string origin, string destination)
    {
        PlanRoute(origin, destination);
        var transport = CreateTransport(goods, tonnage, origin);
        transport.MoveTo(origin);
        transport.Load(tonnage);
        transport.MoveTo(destination);
        transport.Unload();
    }

    protected abstract ITransport CreateTransport(string goods, int tonnage, string location);

    private static void PlanRoute(string origin, string destination)
    {
        Console.WriteLine($"Planning route from {origin} to {destination}...");
    }
}
