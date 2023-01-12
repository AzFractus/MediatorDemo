using MediatR;

namespace WithMediator.Services;

public class ServiceOne
{
    private readonly IMediator _mediator;

    public ServiceOne(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ServiceOne)} executed");
    }
}
