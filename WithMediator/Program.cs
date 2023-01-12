using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WithMediator.Services;

await Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //Register mediatR (Mediator implementation)
        services.AddMediatR(typeof(Program).Assembly);

        //Register service dependencies
        services.AddTransient<ServiceOne>();
        services.AddTransient<ServiceTwo>();
        services.AddTransient<ServiceThree>();
    })
    .RunConsoleAsync();