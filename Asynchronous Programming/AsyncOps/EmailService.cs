namespace AsyncOps;

public class EmailService
{
    public EmailService()
    {
        
    }

    public async Task<bool> SendAsync()
    {
        Thread.Sleep(3000);
        Console.WriteLine("Emails sent successfully");
        return true;
    }
    public bool Send()
    {
        Thread.Sleep(3000);
        Console.WriteLine("Emails sent successfully");
        return true;
    }
}