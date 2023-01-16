namespace WithoutMediator.Services;

public class ServiceTwo
{
    public ServiceTwo()
    {
    }

    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ServiceTwo)} executed");
    }
}
