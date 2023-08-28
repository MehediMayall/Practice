/*
Delegates:

Delegates is an object that knows how to call a method.

A delegate type defines the kind of method that delegate instances can call. 
It defines method return type and its parameter types.

delegate int transformer(int x);

Transformer is compatible with any method with an interger return type and a single int parameter. 
Such as 

int Square(int x) {return x * x;}

Assigning a method to a delegate variable creates a delegate instance;

Transformer t = Square;

You can call a delegate instance in the same way as a method.

int answar = t(3);

*/

public class Delegates
{
    delegate int Transformer(int x);        // Delegate type declaration
    delegate T TransformerGeneric<T>(T x);  // Generic Delegate type declaration
    static int Square(int x)=> x * x;
    static float Square(float x)=> x * x;
    static decimal Square(decimal x)=> x * x;
    static double Square(double x)=> x * x;
    

    static int Cube(int x)=> x * x * x;

    static void Transform(int[] Values, Transformer transformer)
    {
        foreach(int value in Values) print(transformer(value));        
    }

    static void TransformGeneric<T>(T[] Values, TransformerGeneric<T> transformer)
    {
        for (int x=0;x<Values.Length;x++) Values[x] = transformer(Values[x]);
    }

    public static void print(object message) => Console.WriteLine(message);


    public static void Main(string[] args)
    {
        Transformer t = Square;
        print(t(3));
        print(t(99));

        print(t.Target);

        // 

        int[] Values = { 1,2,3,4,5,6,7,8};

        // Using Square
        print("\r\nUsing Square");
        Transform(Values, Square);

        // Using Cube
        print("\r\nUsing Cube");
        Transform(Values, Cube);


        int[] ValuesInt= {3,4,5,6};
        decimal[] ValuesDecimal = {7.2M,8.6M,9.0M};
        double[] ValuesDouble = {3.3,4.3,5.2,6.4};
        float[] ValuesFloat = { 7.5F, 6.5F}; 

        print("Integer Type \r\n");
        TransformGeneric<int>(ValuesInt,Square);
        foreach(int item in ValuesInt) print(item);

        print("Decimal Type \r\n");
        TransformGeneric<decimal>(ValuesDecimal, Square);
        foreach(int item in ValuesDecimal) print(item);

        print("Double Type \r\n");
        TransformGeneric<double>(ValuesDouble, Square);
        foreach(int item in ValuesDouble) print(item);



    }
}