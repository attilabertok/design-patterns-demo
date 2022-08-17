using Strategy.Dive.Common.Routing;
using Strategy.Dive.Final.Navigators.Interfaces;
using Strategy.Dive.Final.RoutingStrategies;
using Strategy.Dive.Final.RoutingStrategies.Interfaces;

namespace Strategy.Dive.Final.Navigators;

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
