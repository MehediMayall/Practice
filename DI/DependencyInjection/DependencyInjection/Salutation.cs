namespace DependencyInjection;

public class Salutation
{
    public IMessageWriter writer;
    public Salutation(IMessageWriter writer) // Injecting IMessageWriter Dependency using Constructor Injection
    {

        if(writer == null) throw new ArgumentNullException("Writer");
        this.writer = writer;
    }

    public void Exclaim()
    {
        this.writer.Write("Hello DI!");
    }


}


