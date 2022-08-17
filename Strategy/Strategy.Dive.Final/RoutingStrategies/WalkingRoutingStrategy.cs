using System.Collections.Immutable;

using Strategy.Dive.Common;
using Strategy.Dive.Common.Routing;
using Strategy.Dive.Final.RoutingStrategies.Interfaces;

namespace Strategy.Dive.Final.RoutingStrategies;

public class WalkingRoutingStrategy : IRoutingStrategy
{
    public Route BuildRoute(RouteParameters routeParameters)
    {
        const string action = "Walk";
        var routePoints = new List<RoutePoint>
        {
            new(routeParameters.Source, "Depart", routeParameters.DepartAt, routeParameters.DepartAt),
            new(routeParameters.Source, $"{action} along Bartók Béla út towards Szent Gellért tér", routeParameters.DepartAt, routeParameters.DepartAt.AddMinutes(14)),
            new(Locations.SzentGellertTer, "Turn left to Műegyetem rakpart", routeParameters.DepartAt.AddMinutes(14), routeParameters.DepartAt.AddMinutes(14)),
            new(Locations.SzentGellertTer, $"{action} along Műegyetem rakpart towards Szabadság híd", routeParameters.DepartAt.AddMinutes(14), routeParameters.DepartAt.AddMinutes(18)),
            new(Locations.SzabadsagHid, "Turn rigth to Szabadság híd", routeParameters.DepartAt.AddMinutes(18), routeParameters.DepartAt.AddMinutes(18)),
            new(Locations.SzabadsagHid, $"{action} across Szabadság híd", routeParameters.DepartAt.AddMinutes(18), routeParameters.DepartAt.AddMinutes(26)),
            new(Locations.FovamTer, $"Continue to {action} straight following Vámház körút towards Astoria", routeParameters.DepartAt.AddMinutes(26), routeParameters.DepartAt.AddMinutes(46)),
            new(Locations.Astoria, "Turn right to Rákóczi út", routeParameters.DepartAt.AddMinutes(46), routeParameters.DepartAt.AddMinutes(46)),
            new(Locations.Astoria, $"{action} along Rákóczi út towards Keleti Pályaudvar", routeParameters.DepartAt.AddMinutes(46), routeParameters.DepartAt.AddMinutes(90)),
            new(Locations.KeletiPalyaudvar, "Turn right to Kerepesi út towards Puskás Ferenc Stadion", routeParameters.DepartAt.AddMinutes(90), routeParameters.DepartAt.AddMinutes(90)),
            new(routeParameters.Destination, "Arrive at destination", routeParameters.DepartAt.AddMinutes(114), default)
        }.ToImmutableList();

        return new Route(routePoints, routeParameters.Method, Budget.None, routePoints.CalculateDuration());
    }
}
