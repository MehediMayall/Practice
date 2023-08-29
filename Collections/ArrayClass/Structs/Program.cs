
/*
Struct

A struct is similar to Class, with the following key differences:

1. Struct is value type and Class is reference type.
2. A struct does not support Inheritance but class do.

Default Constructor

*/

// struct Point{public int x, y;}

struct Point
{
    public int x = 1;
    public int y;

    public Point() => y = 1;
}

public class Structs
{
    public static void print(object message) => Console.WriteLine(message);

    public static void Main(string[] args)
    {
        print(new Point().x);

        Point point= new Point();
        print(point.x);

        point = default;

        print(point.x);


        var points = new Point[10];

    }

}



