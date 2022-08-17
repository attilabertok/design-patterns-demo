namespace Strategy.HeadFirst.Common.Infrastructure;

public static class DuckExtensions
{
    public static void Describe(string typeName, Func<string> action)
    {
        Console.WriteLine($"[{typeName}] - [{action.Method.Name}]: {action()}");
    }
}
