namespace OrderProcessorDelegates;


public class Program
{

    public static void Main(string[] args)
    {
        Order order = new Order{ CustomerName = "Mehedi", NetAmount= 100.50};
        SendMessage sendMessage= new SendMessage();
        
        // To which function
        OrderProcessor processor = new(){
            onOrderInitialized = sendMessage.ToWarehouse
        }; 

        OrderProcessor processor2 = new(){
            onOrderInitialized = sendMessage.SendEmailNotification
        };

        
        processor.Process(order, sendMessage.SendEmailNotification);

    }
}

