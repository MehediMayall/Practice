namespace DelegatesDemo;

public class EventSample
{
    public static event Action<string> SomethingHappened;
    public static event Func<string, int> CalculateTaskLength;


    public static void DoSomething(string Taskname)
    {
        System.Console.WriteLine($"I'm doing something here.\n\tMy Task: {Taskname}");
        if (SomethingHappened is not null) SomethingHappened($"I did task: {Taskname}");
        if (CalculateTaskLength is not null)
        {
            Console.WriteLine($"Task Length: {CalculateTaskLength(Taskname)}");
        }
    }
}