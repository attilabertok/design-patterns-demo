using Strategy.Dive.Common;

namespace Strategy.Dive.Final
{
    public static class Program
    {
        public static void Main()
        {
            var navigator = new Navigator();
            var walkingRoute = navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Walking, DateTimeOffset.Now));
            var bikingRoute = navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Biking, DateTimeOffset.Now));
            var publicTransportRoute = navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.PublicTransport, DateTimeOffset.Now));
            var drivingRoute = navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Driving, DateTimeOffset.Now));

            Console.WriteLine(walkingRoute);
            Console.WriteLine(bikingRoute);
            Console.WriteLine(publicTransportRoute);
            Console.WriteLine(drivingRoute);

            Console.ReadLine();
        }
    }
}
