using Strategy.Dive.Common;

namespace Strategy.Dive.Final.Navigators.Interfaces;

public interface INavigator
{
    Route BuildRoute(RouteParameters routeParameters);
}
