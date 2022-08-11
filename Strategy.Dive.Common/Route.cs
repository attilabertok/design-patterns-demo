using System.Collections.Immutable;
using System.Text;

namespace Strategy.Dive.Common;

public class Route
{
    public Route(ImmutableList<RoutePoint> routePoints, Method method, Budget budget, TimeSpan duration)
    {
        RoutePoints = routePoints;
        Method = method;
        Budget = budget;
        Duration = duration;
    }

    public ImmutableList<RoutePoint> RoutePoints { get; }

    public Method Method { get; }

    public Budget Budget { get; }

    public TimeSpan Duration { get; }

    public override string ToString()
    {
        var sb = new StringBuilder()
            .AppendLine($"{Method} route between {RoutePoints.First().Location} and {RoutePoints.Last().Location}");

        foreach (var routePoint in RoutePoints)
        {
            sb.AppendLine(routePoint.ToString());
        }

        sb.Append("Total Duration: ").AppendLine(Duration.ToString())
            .Append("Total Budget: ").AppendLine(Budget.ToString());

        return sb.ToString();
    }
}
