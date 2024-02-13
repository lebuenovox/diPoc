using Microsoft.Extensions.DependencyInjection;
namespace diPoc;

public interface IReportServiceLifetime
{
    Guid Id { get; }
    ServiceLifetime Lifetime { get; }
}
