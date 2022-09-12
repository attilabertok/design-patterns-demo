using Autofac;
using Decorator.Ican.Di.Common.Reporting;
using Decorator.Ican.Di.Common.Reporting.Decorators;
using Decorator.Ican.Di.Common.Reporting.Interfaces;

namespace Decorator.Ican.Di.AutoFac
{
    public static class Program
    {
        public static void Main()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<ReportingService>()
                .Named<IReportingService>(ReportingService.ServiceName);
            cb.RegisterDecorator<IReportingService>((_, service) => new LoggingReportingService(service), ReportingService.ServiceName);

            using var c = cb.Build();

            var service = c.Resolve<IReportingService>();
            service.Report();
        }
    }
}
