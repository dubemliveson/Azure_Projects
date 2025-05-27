using Microsoft.Azure.Functions.Worker.Configuration;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults() 

// var builder = FunctionsApplication.CreateBuilder(args);

// builder.ConfigureFunctionsWebApplication();

// Application Insights isn't enabled by default. See https://aka.ms/AAt8mw4.
// builder.Services
//     .AddApplicationInsightsTelemetryWorkerService()
//     .ConfigureFunctionsApplicationInsights();

.Build();

host.Run();

// builder.Build().Run();
