public class BaseClass
{
    public virtual void print()=> Console.WriteLine("From Base Class");
}

public class Overrider: BaseClass
{
    public override void print()=> Console.WriteLine("From Override Class");
}

public class Hider: BaseClass
{
    public new void print()=> Console.WriteLine("From Hider Class");
}

public class NewVSOverride
{
    public static void Main(string[] args)
    {
        Overrider overrider= new Overrider();
        BaseClass baseClass = overrider;
        baseClass.print();  // From Override Class
        overrider.print();  // From Override Class

        Hider hider = new Hider();
        BaseClass baseClass2 = hider;
        baseClass2.print();     // From Base Class
        hider.print();          // From Hider Class 
    }
}