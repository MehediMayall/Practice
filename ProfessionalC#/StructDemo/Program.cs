using static System.Console;

Coordinate co = new Coordinate { X = 10, Y = 30, Z = 23};

Coordinate co2 = co with {X = 25};

WriteLine($"X: {co.X}, Y: {co.Y}, Z: {co.Z}");

WriteLine($"X: {co2.X}, Y: {co2.Y}, Z: {co2.Z}");

// Point - Record Struct

Point point = new Point(50,70);
WriteLine(point.GetType());
WriteLine($"X: {point.X}, Y: {point.Y}");


public readonly struct Coordinate
{
    public Coordinate()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }
    public int X { get; init; }
    public int Y { get; init; }
    public int Z { get; init; }
}

public readonly record struct Point(int X, int Y);