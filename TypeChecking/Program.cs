/*
1. GetType - is a runtime type checking of an instance
2. Typeof - is a compile time type checking

*/

public class Asset
{
    public string Name { get; set;}
}

public class TypeChecking
{
    public static void print(object message) => Console.WriteLine(message);

    public static void Main(string[] args)
    {
        Asset asset= new Asset();
        
        print(asset.GetType().Name);
        print(typeof(Asset).Name);

        print(asset.GetType() == typeof(Asset));

    }
}