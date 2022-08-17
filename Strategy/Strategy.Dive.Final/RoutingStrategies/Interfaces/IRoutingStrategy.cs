using Strategy.Dive.Common;

namespace Strategy.Dive.Final.RoutingStrategies.Interfaces;

public interface IRoutingStrategy
{
    Route BuildRoute(RouteParameters routeParameters);
}
