using System.Collections.Immutable;

using Strategy.Dive.Common;
using Strategy.Dive.Final.RoutingStrategies.Interfaces;

namespace Strategy.Dive.Final.RoutingStrategies;

public class PublicTransportRoutingStrategy : IRoutingStrategy
{
    public Route BuildRoute(RouteParameters routeParameters)
    {
        var routePoints = new List<RoutePoint>
        {
            new(routeParameters.Source, "Depart", routeParameters.DepartAt, routeParameters.DepartAt),
            new(Locations.MoriczZsigmondKorter, "Take train 4 towards Keleti Pályaudvar", routeParameters.DepartAt.AddMinutes(5), routeParameters.DepartAt.AddMinutes(7)),
            new(Locations.KeletiPalyaudvar, "Change to underground line 2", routeParameters.DepartAt.AddMinutes(23), routeParameters.DepartAt.AddMinutes(25)),
            new(Locations.KeletiPalyaudvar, "Take train 2 towards Örs vezér tere", routeParameters.DepartAt.AddMinutes(25), routeParameters.DepartAt.AddMinutes(28)),
            new(Locations.MoriczZsigmondKorter, "Get off at Puskás Ferenc Stadion", routeParameters.DepartAt.AddMinutes(30), routeParameters.DepartAt.AddMinutes(30)),
            new(routeParameters.Destination, "Arrive at destination", routeParameters.DepartAt.AddMinutes(35), default)
        }.ToImmutableList();

        return new Route(routePoints, routeParameters.Method, Budget.Medium, routePoints.CalculateDuration());
    }
}
