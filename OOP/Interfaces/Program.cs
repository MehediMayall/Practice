/*
Interface:
An interface is similar to a class but it does not hold state (data).
An interface can define only functions not fields.

*/

public interface IRedoable
{
    public int index { get; set; }
    public string name { get; set; }
    void Redo();
}
public interface IUndoable
{
    void Undo();
    
}

public interface IActions: IRedoable, IUndoable
{

}


public class Actions: IActions
{
    public int index { get; set; }
    public string name { get; set;}

    public static void print(object message) => Console.WriteLine(message);

    public void Redo()
    {        
        print("Redoing...");
    }
    public void Undo()
    {
        print("Undoing...");
    }

    private void doNothing()
    {
        index = 0;
    }

    
}


public interface ILog
{
    void LogConsole(string message);
}


public interface ILogger: ILog
{
    // public string LoginFile();
    // Interface function implementation

    static string name = "";
    public void Log(string message)=> Console.WriteLine(message);
}

public class Logger: ILogger
{
    public void LogConsole(string message)=> Console.WriteLine(message);
}

public class BaseClass
{
    internal void setMessge(string message) => Console.WriteLine(message);
}

public class SubClass: BaseClass
{

}

    

public class Interfaces
{
    public static void print(object message) => Console.WriteLine(message);
    public static void Main(string[] args)
    {
        Actions actions= new Actions();
        actions.Redo();

        // new Logger()

        // new Logger().Log("Hello Mars");
        ((ILogger) new Logger()).Log("Hello Mars");

        SubClass sub = new SubClass();
        sub.setMessge("");

        BaseClass baseClass = sub;
        BaseClass baseC = new BaseClass();
        baseC.setMessge("");
        

    }
}
