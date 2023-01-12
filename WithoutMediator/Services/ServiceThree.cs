namespace WithoutMediator.Services;

public class ServiceThree
{
    private readonly ServiceOne _one;
    private readonly ServiceTwo _two;

    public ServiceThree(ServiceOne one, ServiceTwo two)
    {
        _one = one;
        _two = two;
    }
    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ServiceThree)} executed");
    }
}
