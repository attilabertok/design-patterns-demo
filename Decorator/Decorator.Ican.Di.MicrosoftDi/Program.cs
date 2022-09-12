using Decorator.Ican.Di.Common.Reporting;
using Decorator.Ican.Di.Common.Reporting.Decorators;
using Decorator.Ican.Di.Common.Reporting.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Decorator.Ican.Di.MicrosoftDi
{
    /// <remarks>
    /// The built-in Microsoft Dependency Injection library does not support injection based on name or decoration out of the box.
    /// The Scrutor NuGet package adds support for decoration.
    /// </remarks>
    /// <see href="https://andrewlock.net/adding-decorated-classes-to-the-asp.net-core-di-container-using-scrutor/"/>
    /// <seealso href="https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-guidelines#default-service-container-replacement"/>
    public static class Program
    {
        public static void Main()
        {
            var builder = Host.CreateDefaultBuilder();
            builder.ConfigureServices(services => services.AddTransient<IReportingService, ReportingService>()
                .Decorate<IReportingService, LoggingReportingService>());

            using var host = builder.Build();

            var service = host.Services.GetRequiredService<IReportingService>();
            service.Report();
        }
    }
}
