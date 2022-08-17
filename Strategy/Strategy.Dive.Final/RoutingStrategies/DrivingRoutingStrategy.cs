using System.Collections.Immutable;

using Strategy.Dive.Common;
using Strategy.Dive.Final.RoutingStrategies.Interfaces;

namespace Strategy.Dive.Final.RoutingStrategies;

public class DrivingRoutingStrategy : IRoutingStrategy
{
    public Route BuildRoute(RouteParameters routeParameters)
    {
        const string action = "Drive";
        var routePoints = new List<RoutePoint>
        {
            new(routeParameters.Source, "Depart", routeParameters.DepartAt, routeParameters.DepartAt),
            new(routeParameters.Source, $"{action} along Bartók Béla út towards Szent Gellért tér", routeParameters.DepartAt, routeParameters.DepartAt.AddMinutes(3)),
            new(Locations.SzentGellertTer, "Turn left to Műegyetem rakpart", routeParameters.DepartAt.AddMinutes(3), routeParameters.DepartAt.AddMinutes(3)),
            new(Locations.SzentGellertTer, $"{action} along Műegyetem rakpart towards Szabadság híd", routeParameters.DepartAt.AddMinutes(3), routeParameters.DepartAt.AddMinutes(4)),
            new(Locations.SzabadsagHid, "Turn rigth to Szabadság híd", routeParameters.DepartAt.AddMinutes(4), routeParameters.DepartAt.AddMinutes(4)),
            new(Locations.SzabadsagHid, $"{action} across Szabadság híd", routeParameters.DepartAt.AddMinutes(4), routeParameters.DepartAt.AddMinutes(6)),
            new(Locations.FovamTer, $"Continue to {action} straight following Vámház körút towards Astoria", routeParameters.DepartAt.AddMinutes(6), routeParameters.DepartAt.AddMinutes(10)),
            new(Locations.Astoria, "Turn right to Rákóczi út", routeParameters.DepartAt.AddMinutes(10), routeParameters.DepartAt.AddMinutes(10)),
            new(Locations.Astoria, $"{action} along Rákóczi út towards Keleti Pályaudvar", routeParameters.DepartAt.AddMinutes(10), routeParameters.DepartAt.AddMinutes(18)),
            new(Locations.KeletiPalyaudvar, "Turn right to Kerepesi út towards Puskás Ferenc Stadion", routeParameters.DepartAt.AddMinutes(18), routeParameters.DepartAt.AddMinutes(18)),
            new(routeParameters.Destination, "Arrive at destination", routeParameters.DepartAt.AddMinutes(23), default)
        }.ToImmutableList();

        return new Route(routePoints, routeParameters.Method, Budget.High, routePoints.CalculateDuration());
    }
}
