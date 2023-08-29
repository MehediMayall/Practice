namespace OrderProcessorDelegates;

public class SendMessage
{
    private void print(object message)=> System.Console.WriteLine(message);

    public Boolean ToWarehouse(Order order)
    {
        print($"Please pack the order for Customer Name: {order.CustomerName}, Order Id: {order.Id} ");
        return true;
    }

    public Boolean SendEmailNotification(Order order)
    {
        print($"An email has been sent to the customer.  for Customer Name: {order.CustomerName}, Order Id: {order.Id}");
        return true;
    }
}