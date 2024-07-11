namespace DisposeAndFinalize;

public class LogService: IDisposable
{
    private readonly StreamWriter streamWriter;
    public LogService() => streamWriter = new StreamWriter("log.txt",true);

    public void log(string message) 
    {
        streamWriter.Write($"{DateTime.Now.ToString()}: {message}");
        streamWriter.Flush();
    }

    ~LogService() => Console.WriteLine("LogService is being destructed!");
    public void Dispose() 
    {   
        System.Console.WriteLine("LogService is being disposed");
        streamWriter.Dispose();
    }

}