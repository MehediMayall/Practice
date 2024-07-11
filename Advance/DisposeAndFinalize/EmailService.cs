namespace DisposeAndFinalize;

public class EmailService
{
    public void Send()
    {
        System.Console.WriteLine("Sent email successfully");
    }

    ~EmailService() => System.Console.WriteLine("EmailService is being destructed");
}