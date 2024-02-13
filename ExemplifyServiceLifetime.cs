using Microsoft.Extensions.DependencyInjection;

namespace diPoc;

public static class ExemplifyServiceLifetime
{
    public static void Exec(IServiceProvider hostProvider, string lifetime)
    {
        using IServiceScope serviceScope = hostProvider.CreateScope();
        IServiceProvider provider = serviceScope.ServiceProvider;
        ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
        logger.ReportServiceLifetimeDetails(
            $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");

        Console.WriteLine("...");

        logger = provider.GetRequiredService<ServiceLifetimeReporter>();
        logger.ReportServiceLifetimeDetails(
            $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()");

        Console.WriteLine();
    }
}
