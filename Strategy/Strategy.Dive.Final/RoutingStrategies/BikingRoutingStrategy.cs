using System.Collections.Immutable;

using Strategy.Dive.Common;
using Strategy.Dive.Common.Routing;
using Strategy.Dive.Final.RoutingStrategies.Interfaces;

namespace Strategy.Dive.Final.RoutingStrategies;

public class BikingRoutingStrategy : IRoutingStrategy
{
    public Route BuildRoute(RouteParameters routeParameters)
    {
        const string action = "Ride";
        var routePoints = new List<RoutePoint>
        {
            new(routeParameters.Source, "Depart", routeParameters.DepartAt, routeParameters.DepartAt),
            new(routeParameters.Source, $"{action} along Bartók Béla út towards Szent Gellért tér", routeParameters.DepartAt, routeParameters.DepartAt.AddMinutes(7)),
            new(Locations.SzentGellertTer, "Turn left to Műegyetem rakpart", routeParameters.DepartAt.AddMinutes(7), routeParameters.DepartAt.AddMinutes(7)),
            new(Locations.SzentGellertTer, $"{action} along Műegyetem rakpart towards Szabadság híd", routeParameters.DepartAt.AddMinutes(7), routeParameters.DepartAt.AddMinutes(9)),
            new(Locations.SzabadsagHid, "Turn rigth to Szabadság híd", routeParameters.DepartAt.AddMinutes(9), routeParameters.DepartAt.AddMinutes(9)),
            new(Locations.SzabadsagHid, $"{action} across Szabadság híd", routeParameters.DepartAt.AddMinutes(9), routeParameters.DepartAt.AddMinutes(13)),
            new(Locations.FovamTer, $"Continue to {action} straight following Vámház körút towards Astoria", routeParameters.DepartAt.AddMinutes(13), routeParameters.DepartAt.AddMinutes(23)),
            new(Locations.Astoria, "Turn right to Rákóczi út", routeParameters.DepartAt.AddMinutes(23), routeParameters.DepartAt.AddMinutes(23)),
            new(Locations.Astoria, $"{action} along Rákóczi út towards Keleti Pályaudvar", routeParameters.DepartAt.AddMinutes(23), routeParameters.DepartAt.AddMinutes(45)),
            new(Locations.KeletiPalyaudvar, "Turn right to Kerepesi út towards Puskás Ferenc Stadion", routeParameters.DepartAt.AddMinutes(45), routeParameters.DepartAt.AddMinutes(45)),
            new(routeParameters.Destination, "Arrive at destination", routeParameters.DepartAt.AddMinutes(57), default)
        }.ToImmutableList();

        return new Route(routePoints, routeParameters.Method, Budget.None, routePoints.CalculateDuration());
    }
}
