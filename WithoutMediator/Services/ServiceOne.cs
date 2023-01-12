namespace WithMediator.Services;

public class ServiceOne
{
    private readonly ServiceTwo _two;
    private readonly ServiceThree _three;

    public ServiceOne(ServiceTwo two, ServiceThree three)
	{
		_two = two;
		_three = three;
	}

	public void DoSomething()
	{
		Console.WriteLine($"{nameof(ServiceOne)} executed");
	}
}
