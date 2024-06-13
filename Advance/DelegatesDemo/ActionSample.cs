namespace DelegatesDemo;

// An Action is by default a delegate. It's a shorter version of delegate which may
// take 0 or upto 16 parameters and return void
public class ActionSample
{
    public static void Show()
    {
        Action action = DisplayGreet; 
        action += DisplayDateAndTime;
        action.Invoke();

        Action<string> messageAction = DisplayMessage;
        messageAction.Invoke("This action has been invoked with a string parameter");

    }

    public static void DisplayGreet()
    {
        System.Console.WriteLine("Hello from Action!");
    }
    public static void DisplayDateAndTime()
    {
        System.Console.WriteLine(DateTime.Now.ToString());
    }


    public static void DisplayMessage(string Message)
    {
        System.Console.WriteLine(Message);
    }


}