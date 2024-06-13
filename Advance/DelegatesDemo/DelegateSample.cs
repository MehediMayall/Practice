namespace DelegatesDemo;

public class DelegateSample
{
    public delegate void MathDelegate(int first, int second);

    public static void Show()
    {
        // Adding Add function as function pointer to the delegate
        var mathDelegate = new MathDelegate(Add);

        // Method Chaining - adding more functions with the delegate
        mathDelegate += Subtract;
        mathDelegate += Multiply;
        mathDelegate += Divide;

        // Invoking delegate with parameters
        // DelegateHandler(mathDelegate);

        // // Removing methods from the delegate
        // System.Console.WriteLine("\nAfter removing Multiply & Divide function:\n");
        // mathDelegate -= Multiply;
        // mathDelegate -= Divide;
        // DelegateHandler(mathDelegate);

        // Generic Delegate Handler
        GenericDelegateHandler(mathDelegate);
    }


    // Generic Delegate Handler - Using Dynamic Invoke
    public static void GenericDelegateHandler(Delegate del)
    {
        del?.DynamicInvoke(500, 240);
    }

    // Specific Delegate Handler
    public static void DelegateHandler(MathDelegate mathDelegate)
    {
        mathDelegate?.Invoke(200,15);
    }

    public static void Add(int first, int second)
    {
        System.Console.WriteLine($"Add: {first + second}");
    }


    public static void Multiply(int first, int second)
    {
        System.Console.WriteLine($"Mul: {first * second}");
    }

    public static void Subtract(int first, int second)
    {
        System.Console.WriteLine($"Sub: {first - second}");
    }

    public static void Divide(int first, int second)
    {
        System.Console.WriteLine($"Div: {first / second}");
    }
}