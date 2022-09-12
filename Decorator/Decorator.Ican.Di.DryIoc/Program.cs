using Decorator.Ican.Di.Common.Reporting;
using Decorator.Ican.Di.Common.Reporting.Decorators;
using Decorator.Ican.Di.Common.Reporting.Interfaces;
using DryIoc;

namespace Decorator.Ican.Di.DryIoc
{
    /// <see href="https://github.com/dadhi/DryIoc/blob/master/docs/DryIoc.Docs/Decorators.md"/>>
    public static class Program
    {
        public static void Main()
        {
            var container = new Container();
            container.Register<IReportingService, ReportingService>();
            container.Register<IReportingService, LoggingReportingService>(setup: Setup.Decorator);

            var service = container.Resolve<IReportingService>();
            service.Report();
        }
    }
}
