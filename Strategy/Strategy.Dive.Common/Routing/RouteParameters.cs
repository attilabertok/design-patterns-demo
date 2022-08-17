namespace Strategy.Dive.Common.Routing;

public readonly record struct RouteParameters(Location Source, Location Destination, Method Method, DateTimeOffset DepartAt);
