using MediatR;

namespace WithoutMediator.Services;

public class ServiceTwo
{
    private readonly IMediator _mediator;

    public ServiceTwo(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ServiceTwo)} executed");
    }
}
