using Strategy.Dive.Common;

namespace Strategy.Dive.Final;

public interface INavigator
{
    Route BuildRoute(RouteParameters routeParameters);
}