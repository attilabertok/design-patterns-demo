using Decorator.Ican.Di.Common.Reporting.Interfaces;

namespace Decorator.Ican.Di.Common.Reporting;

public class ReportingService : IReportingService
{
    public static string ServiceName { get; } = nameof(ReportingService);

    public void Report()
    {
        Console.WriteLine("Here's your report!");
    }
}
