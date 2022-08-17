using System.Collections.Immutable;
using Strategy.Dive.Common.Routing;
using Strategy.Dive.Final.Navigators.Interfaces;
using Strategy.Dive.Final.RoutingStrategies;
using Strategy.Dive.Final.RoutingStrategies.Interfaces;

namespace Strategy.Dive.Final.Navigators;

public class LazyDictionaryNavigator : INavigator
{
    private readonly ImmutableDictionary<Method, Lazy<IRoutingStrategy>> routingStrategies = new Dictionary<Method, Lazy<IRoutingStrategy>>()
    {
        [Method.Driving] = new(() => new DrivingRoutingStrategy()),
        [Method.PublicTransport] = new(() => new PublicTransportRoutingStrategy()),
        [Method.Biking] = new(() => new BikingRoutingStrategy()),
        [Method.Walking] = new(() => new WalkingRoutingStrategy())
    }.ToImmutableDictionary();

    public Route BuildRoute(RouteParameters routeParameters)
    {
        if (routingStrategies.TryGetValue(routeParameters.Method, out var routingStrategy))
        {
            return routingStrategy.Value.BuildRoute(routeParameters);
        }

        throw new ArgumentOutOfRangeException(nameof(routeParameters), routeParameters.Method, "Invalid routing method.");
    }
}
