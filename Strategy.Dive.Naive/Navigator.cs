using System.Collections.Immutable;
using Strategy.Dive.Common;

namespace Strategy.Dive.Naive;

public static class Navigator
{
    public static Route BuildRoute(RouteParameters routeParameters)
    {
        return routeParameters.Method switch
        {
            Method.Driving => BuildDrivingRoute(routeParameters),
            Method.Walking => BuildWalkingRoute(routeParameters),
            Method.Biking => BuildBikingRoute(routeParameters),
            Method.PublicTransport => BuildPublicTransportRoute(routeParameters),
            _ => throw new ArgumentOutOfRangeException(nameof(routeParameters), routeParameters.Method, "Unknown travel method")
        };
    }

    private static Route BuildPublicTransportRoute(RouteParameters routeParameters)
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

    private static Route BuildBikingRoute(RouteParameters routeParameters)
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

    private static Route BuildWalkingRoute(RouteParameters routeParameters)
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

    private static Route BuildDrivingRoute(RouteParameters routeParameters)
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
