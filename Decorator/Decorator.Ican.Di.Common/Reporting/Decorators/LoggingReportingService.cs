using Decorator.Ican.Di.Common.Reporting.Interfaces;

namespace Decorator.Ican.Di.Common.Reporting.Decorators;

public class LoggingReportingService :
    IReportingService
{
    private readonly IReportingService wrappedService;

    public LoggingReportingService(IReportingService wrappedService)
    {
        this.wrappedService = wrappedService;
    }

    public void Report()
    {
        Console.WriteLine("Logging...");
        wrappedService.Report();
        Console.WriteLine("Logged.");
    }
}
