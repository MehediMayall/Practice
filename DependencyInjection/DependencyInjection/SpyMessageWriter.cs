namespace DependencyInjection;
public class SpyMessageWriter: IMessageWriter
{
    public string WrittenMessage {get;set;}
    public void Write(string message)
    {
        this.WrittenMessage += message;
    }
}