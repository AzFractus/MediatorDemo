using Microsoft.Extensions.Hosting;
using WithoutMediator.Services;

namespace WithoutMediator;

public class Worker : IHostedService
{
    private readonly ServiceOne _one;

    public Worker(ServiceOne one)
    {
        _one = one;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _one.DoSomething();

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
