namespace WithMediator.Services;

public class ServiceTwo
{
    private readonly ServiceOne _one;
    private readonly ServiceThree _three;

    public ServiceTwo(ServiceOne one, ServiceThree three)
	{
		_one = one;
		_three = three;
	}

    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ServiceTwo)} executed");
    }
}
