using System.Collections.Immutable;
using Strategy.Dive.Common;
using Strategy.Dive.Final.RoutingStrategies;

namespace Strategy.Dive.Final;

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
