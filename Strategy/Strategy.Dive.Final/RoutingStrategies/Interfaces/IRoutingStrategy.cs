using Strategy.Dive.Common.Routing;

namespace Strategy.Dive.Final.RoutingStrategies.Interfaces;

public interface IRoutingStrategy
{
    Route BuildRoute(RouteParameters routeParameters);
}
