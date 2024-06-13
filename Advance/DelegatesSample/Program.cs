using DelegateSamples; 

DelegateSample.PassMeWork(WriteMessage);


static void WriteMessage(string message)
{
    System.Console.WriteLine(message);
}