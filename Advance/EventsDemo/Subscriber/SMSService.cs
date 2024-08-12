namespace EventsDemo;

public class SMSService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("\n---: SMS Service :---");
        Console.WriteLine($"{e.video}");
        Console.WriteLine("A sms sent!\n");
    }
}