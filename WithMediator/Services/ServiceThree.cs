using MediatR;

namespace WithMediator.Services;

public class ServiceThree
{
    private readonly IMediator _mediator;

    public ServiceThree(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ServiceThree)} executed");
    }
}