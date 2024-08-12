namespace EventsDemo;

public class EmailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("\n---: Email Service :---");
        Console.WriteLine($"{e.video}");
        Console.WriteLine("An email sent!\n");
    }
}
