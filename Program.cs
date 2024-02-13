using diPoc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();
builder.Services.AddScoped<IExampleScopedService, ExampleScopedService>();
builder.Services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();
builder.Services.AddTransient<ServiceLifetimeReporter>();

using IHost host = builder.Build();

ExemplifyServiceLifetime.Exec(host.Services, "Lifetime 1");
ExemplifyServiceLifetime.Exec(host.Services, "Lifetime 2");
ExemplifyServiceLifetime.Exec(host.Services, "Lifetime 3");

await host.RunAsync();


