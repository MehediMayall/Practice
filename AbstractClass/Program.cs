// ## A class declared as Abstract can't never be instantiated.


public abstract class Asset
{
    public abstract string Name { get; set; }
    public abstract decimal NetValue { get; }

    public int SharesOwned { get; set; }
}

public class Stock: Asset
{
    public override string Name { get; set;}
    public new int SharesOwned { get; set; }    // Hiding inherited member
    public decimal CurrentValue { get; set; }
    public override decimal NetValue => CurrentValue * SharesOwned;
}

public class AbstractClass
{
    public static void print(object message) => Console.WriteLine(message);
    public static void Main(string[] args)
    {
        print("Hello Mars");
    }
}