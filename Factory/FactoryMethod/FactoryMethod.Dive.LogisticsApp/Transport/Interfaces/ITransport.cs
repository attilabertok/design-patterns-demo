namespace FactoryMethod.Dive.LogisticsApp.Transport.Interfaces;

public interface ITransport
{
    public string CargoType { get; }

    public int CargoCapacity { get; }

    public int CurrentCargoAmount { get; }

    public string Location { get; set; }

    void MoveTo(string location);

    void Load(int amount);

    void Unload();
}
