using FactoryMethod.Dive.LogisticsApp.Transport.Interfaces;

namespace FactoryMethod.Dive.LogisticsApp.Transport.Extensions;

public static class TransportExtensions
{
    public static bool IsAvailable(this ITransport transport, string goods, int tonnage)
    {
        return IsCargoTypeCorrect(transport, goods)
               && HasTotalCapacity(transport, tonnage)
               && HasCurrentCapacity(transport, tonnage);
    }

    public static bool IsAtLocation(this ITransport transport, string location)
    {
        return transport.Location == location;
    }

    private static bool IsCargoTypeCorrect(ITransport transport, string goods)
    {
        return transport.CargoType == goods;
    }

    private static bool HasTotalCapacity(ITransport transport, int tonnage)
    {
        return transport.CargoCapacity >= tonnage;
    }

    private static bool HasCurrentCapacity(ITransport transport, int tonnage)
    {
        return transport.CargoCapacity - transport.CurrentCargoAmount >= tonnage;
    }
}
