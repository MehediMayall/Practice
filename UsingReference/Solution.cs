namespace UsingReference;
using static System.Console;

public class Solution
{
    public int getAbsoluteValue(int x)
    {
        return Math.Abs(x);
    }

    public void getAbsoluteValue(ref int x)
    {
        x = Math.Abs(x);
    }

    // public void getMemoryAddress()
    // {
    //     unsafe{
    //         int x = 10, y = 20;
    //         int *addressOfX = &x;
    //         WriteLine(*addressOfX);
    //     }

    // }
}