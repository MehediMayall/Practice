namespace ImplicitExplicitCasting;


public readonly record struct Point(float X, float Y)
{
    
    // Implicit Casting
    public static implicit operator Point((float, float) pointAsTuple) => 
        new Point(pointAsTuple.Item1, pointAsTuple.Item2);
        
}