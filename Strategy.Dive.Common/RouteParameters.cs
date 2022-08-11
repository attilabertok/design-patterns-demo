namespace Strategy.Dive.Common;

public readonly record struct RouteParameters(Location Source, Location Destination, Method Method, DateTimeOffset DepartAt);
