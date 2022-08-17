using System.Text;

namespace Strategy.Dive.Common;

public class RoutePoint
{
    public RoutePoint(Location location, string description, DateTimeOffset arriveAt, DateTimeOffset departAt)
    {
        Location = location;
        Description = description;
        ArriveAt = arriveAt;
        DepartAt = departAt;
    }

    public Location Location { get; }

    public DateTimeOffset ArriveAt { get; }

    public DateTimeOffset DepartAt { get; }

    public string Description { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("@[").Append(ArriveAt).Append("] - [").Append(DepartAt).AppendLine("]")
            .AppendLine(Location.ToString())
            .AppendLine(Description);

        return sb.ToString();
    }
}
