using Strategy.Dive.Common.Routing;

namespace Strategy.Dive.Final.Navigators.Interfaces;

public interface INavigator
{
    Route BuildRoute(RouteParameters routeParameters);
}
