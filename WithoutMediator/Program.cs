using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WithoutMediator.Services;

await Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //Register service dependencies
        services.AddTransient<ServiceOne>();
        services.AddTransient<ServiceTwo>();
        services.AddTransient<ServiceThree>();
    })
    .RunConsoleAsync();