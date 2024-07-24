
// Overloadable operators: C# allows user defined types to overload operators
// by defining static member functions using the operator keyword
// the following example illustrates an implementation of the + operator

using Operators;
using static System.Console;


Complex complexA = new Complex() { Real = 1, Imaginary = 2};
Complex complexB = new Complex() { Real = 4, Imaginary = 8};

Complex complexC = complexA + complexB;

WriteLine($"Real: {complexC.Real}, Imaginary: {complexC.Imaginary}");
