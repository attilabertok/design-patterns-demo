using Strategy.Dive.Common.Routing;
using Strategy.Dive.Final.Navigators;
using Strategy.Dive.Final.Navigators.Interfaces;

namespace Strategy.Dive.Final
{
    public static class Program
    {
        public static void Main()
        {
            var navigators = new List<INavigator>
            {
                new Navigator(),
                new LazyDictionaryNavigator()
            };

            foreach (var navigator in navigators)
            {
                Console.WriteLine($"====[{navigator.GetType().Name}]====");
                Console.WriteLine();

                var walkingRoute = navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Walking, DateTimeOffset.Now));
                var bikingRoute = navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Biking, DateTimeOffset.Now));
                var publicTransportRoute = navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.PublicTransport, DateTimeOffset.Now));
                var drivingRoute = navigator.BuildRoute(new RouteParameters(Locations.MoriczZsigmondKorter, Locations.PuskasFerencStadion, Method.Driving, DateTimeOffset.Now));

                Console.WriteLine($"[{navigator.GetType().Name}]: {walkingRoute}");
                Console.WriteLine($"[{navigator.GetType().Name}]: {bikingRoute}");
                Console.WriteLine($"[{navigator.GetType().Name}]: {publicTransportRoute}");
                Console.WriteLine($"[{navigator.GetType().Name}]: {drivingRoute}");

                Console.WriteLine();
            }
        }
    }
}
