namespace DelegateSamples;

public class DelegateSample
{
    public delegate void Del(string input);

    public static void PassMeWork(Del work)
    {
        work("Hello from PassMeWork");
    }
}