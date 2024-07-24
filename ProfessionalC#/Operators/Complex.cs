
// Overloadable operators: C# allows user defined types to overload operators
// by defining static member functions using the operator keyword
// the following example illustrates an implementation of the + operator
namespace Operators;

public struct Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public static Complex operator +(Complex left, Complex right)
    {
        return new Complex{
            Real = left.Real + right.Real,
            Imaginary = left.Imaginary + right.Imaginary
        };
    }
}

