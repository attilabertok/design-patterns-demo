using Bogus;
using FactoryMethod.Dive.LogisticsApp.Logistics;

namespace FactoryMethod.Dive.LogisticsApp
{
    public static class Program
    {
        public static void Main()
        {
            var faker = new Faker();
            var goods = Enumerable.Range(0, 3).Select(_ => faker.Commerce.ProductName()).ToList();
            var seaLogistics = new SeaLogistics(faker.Address.City(), goods);
            var roadLogistics = new RoadLogistics(faker.Address.City());

            Console.WriteLine("How many pieces of cargo are there to transport?");
            if (!int.TryParse(Console.ReadLine(), out var cargoCount))
            {
                cargoCount = 5;
            }

            for (var i = 0; i < cargoCount; i++)
            {
                var cargo = faker.PickRandom(goods);
                var amount = faker.Random.Int(1, 75);
                var origin = faker.Address.City();
                var destination = faker.Address.City();

                try
                {
                    seaLogistics.PlanDelivery(cargo, amount, origin, destination);
                }
                catch
                {
                    Console.WriteLine("Sea transport not available, trying road transport...");
                    roadLogistics.PlanDelivery(cargo, amount, origin, destination);
                }

                Console.ReadLine();
            }
        }
    }
}
