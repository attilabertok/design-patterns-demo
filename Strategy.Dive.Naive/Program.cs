using Strategy.Dive.Common;

namespace Strategy.Dive.Naive
{
    public static class Program
    {
        public static void Main()
        {
            var walkingRoute = Navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Walking, DateTimeOffset.Now));
            var bikingRoute = Navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Biking, DateTimeOffset.Now));
            var publicTransportRoute = Navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.PublicTransport, DateTimeOffset.Now));
            var drivingRoute = Navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Driving, DateTimeOffset.Now));

            Console.WriteLine(walkingRoute);
            Console.WriteLine(bikingRoute);
            Console.WriteLine(publicTransportRoute);
            Console.WriteLine(drivingRoute);

            Console.ReadLine();
        }
    }
}
