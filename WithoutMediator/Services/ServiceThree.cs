namespace WithoutMediator.Services;

public class ServiceThree
{
    public ServiceThree()
    {
    }

    public void DoSomething()
    {
        Console.WriteLine($"{nameof(ServiceThree)} executed");
    }
}
