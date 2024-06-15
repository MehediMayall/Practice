namespace DelegatesDemo;

// A Func is by default a delegate. It's a shorter version of delegate which may
// take 0 or upto 16 parameters and return values
public class FuncAnonymousSample
{
    public static void Show()
    {

        Func<int, int> adderA, adderB, adderC, adderD;

        // Lambda syntax with statement boy
        adderA = (int x) => { x+= 2; return x; };

        // Lambda syntax with expression body
        adderB = (int x)=> x + 3;

        // Lambda syntax with no parameter type
        adderC = (x)=> x + 5;

        // Lambda syntax when one parameter, parenthesis can be omitted
        adderD = x => x + 10;


        Console.WriteLine(adderA(10));
        Console.WriteLine(adderB(10));
        Console.WriteLine(adderC(10));
        Console.WriteLine(adderD(10));

    }   
}