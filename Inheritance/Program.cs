public class BaseClass
{
    public int X;
    
    public BaseClass()=> print("Base class constructor is being called");
    public BaseClass(int x) => X = x;
    public void print(object message) => Console.WriteLine(message);

}

public class SubClass: BaseClass
{
    public int Y;
    public SubClass(int x) :base(x){}
}

public class Inheritance
{
    public static void Main(string[] args)
    {
        // SubClass sub = new SubClass();
        // sub.print("Hello From Sub");

        new SubClass(20).print("Hello From Sub");
    }
}