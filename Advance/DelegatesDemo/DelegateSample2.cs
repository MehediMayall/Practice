namespace DelegatesDemo;

public class DelegateSample2
{
    public static void PerformTheTask(Action<string> Worker)
    {
        Worker("Close the door");
    }

    public static void PerformAnAddOperation(Func<int,int> Worker)
    {
        Console.WriteLine($"Result: {Worker(10)}");
    }

    public static void Execute(int x, int y, Func<int,int,int> Worker)
    {
        Console.WriteLine($"Result of {x} and {y} = {Worker(x,y)}");
    }


}
