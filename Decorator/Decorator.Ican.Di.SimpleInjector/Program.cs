using Decorator.Ican.Di.Common.Reporting;
using Decorator.Ican.Di.Common.Reporting.Decorators;
using Decorator.Ican.Di.Common.Reporting.Interfaces;
using SimpleInjector;

namespace Decorator.Ican.Di.SimpleInjector
{
    /// <see href="https://docs.simpleinjector.org/en/latest/aop.html#decoration"/>
    public static class Program
    {
        public static void Main()
        {
            var container = new Container();
            container.Register<IReportingService, ReportingService>();
            container.RegisterDecorator<IReportingService, LoggingReportingService>();

            var service = container.GetInstance<IReportingService>();
            service.Report();
        }
    }
}
