using static System.Console;

// Struct is a value type
// Struct does not support inheritance
// Struct does not have finalizer (Destructor)
// Struct members can't be marked as virtual, abstract or protected
// Structs are value type, an instance can't be null.
// Default value of a struct is an empty instance, with all fields empty


// Point p = new Point();  // all member of the struct will have their default value
// Point p2 = default;
// var points = new Point[10];

// WriteLine($"X: {p.x}, Y: {p.y}, Color: {p.Color}");
// WriteLine($"X: {p2.x}, Y: {p2.y}, Color: {p2.Color}");

// foreach(var point in points)
//     WriteLine($"X: {point.x}, Y: {point.y}, Color: {point.Color}");



// struct Point {
//     public int x, y;
//     public string Color;
// }

// struct WebOptions
// {
//     string protocal;
//     public string Protocal 
//     {
//         get => protocal ?? "https";
//         set => protocal = value;
//     }
// }

// Ref Struct
// Adding the ref keyword to a struct's declaration ensures that it can only ever reside on the stack.
// Ref struct can't appear inside non-ref structs.
// Ref struct can't implement interfaces

// Attempting create an array of Ref struct will not compile because it ref struct can't reside on the heap.
// var points = new Point[100];     // will not compile

// class MyClass { Point p;} // will not compile

ref struct Point
{
    public int x,y;
}


