using Strategy.Dive.Common;

namespace Strategy.Dive.Final;

public interface IRoutingStrategy
{
    Route BuildRoute(RouteParameters routeParameters);
}