namespace DelegatesDemo;

// A Func is by default a delegate. It's a shorter version of delegate which may
// take 0 or upto 16 parameters and return values
public class FuncSample
{
    public static void Show()
    {
        // Param1 type, Param2 type, Return type
        Func<int, double, double> orderFunc = GetAmount;
        System.Console.WriteLine(orderFunc.Invoke(3, 124.50));

    }

     
    private static double GetAmount(int Quantity, double Price)
    {
        return Quantity * Price;
    }

}