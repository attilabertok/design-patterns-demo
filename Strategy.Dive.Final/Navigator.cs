using Strategy.Dive.Common;
using Strategy.Dive.Final.RoutingStrategies;

namespace Strategy.Dive.Final;

public class Navigator : INavigator
{
    private IRoutingStrategy? routingStrategy;

    public Route BuildRoute(RouteParameters routeParameters)
    {
        routingStrategy = routeParameters.Method switch
        {
            Method.Driving => new DrivingRoutingStrategy(),
            Method.Walking => new WalkingRoutingStrategy(),
            Method.Biking => new BikingRoutingStrategy(),
            Method.PublicTransport => new PublicTransportRoutingStrategy(),
            _ => throw new ArgumentOutOfRangeException(nameof(routeParameters), routeParameters.Method, "Unknown travel method")
        };

        return routingStrategy.BuildRoute(routeParameters);
    }
}
