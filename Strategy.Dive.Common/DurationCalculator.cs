﻿using System.Collections.Immutable;

namespace Strategy.Dive.Common;

public static class DurationCalculator
{
    public static TimeSpan CalculateDuration(this ImmutableList<RoutePoint> routePoints)
    {
        return routePoints.Last().ArriveAt - routePoints.First().DepartAt;
    }
}
