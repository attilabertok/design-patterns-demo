using FactoryMethod.Dive.LogisticsApp.Transport.Interfaces;

namespace FactoryMethod.Dive.LogisticsApp.Transport;

public class Ship :
    ITransport
{
    public Ship(int cargoCapacity, string cargoType, string initialLocation)
    {
        CargoCapacity = cargoCapacity;
        CargoType = cargoType;
        Location = initialLocation;
    }

    public string CargoType { get; }

    public int CargoCapacity { get; }

    public int CurrentCargoAmount { get; private set; }

    public string Location { get; set; }

    public void MoveTo(string location)
    {
        Console.WriteLine($"Ship is en route to {location}...");
        Location = location;
    }

    public void Load(int amount)
    {
        CurrentCargoAmount = amount;
        Console.WriteLine($"Loading {CurrentCargoAmount} metric tonnes of {CargoType} into the ship's cargo hold.");
    }

    public void Unload()
    {
        Console.WriteLine($"Unloading {CurrentCargoAmount} metric tonnes of {CargoType} from the ship's cargo hold.");
        CurrentCargoAmount = 0;
    }
}
