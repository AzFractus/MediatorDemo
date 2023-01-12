using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace WithoutMediator.Services;

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