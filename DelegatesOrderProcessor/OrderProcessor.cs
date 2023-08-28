namespace OrderProcessorDelegates;


public class OrderProcessor
{
    public delegate Boolean OrderInitialized(Order order);
    public delegate Boolean OrderCompleted(Order order);

    
    public OrderInitialized onOrderInitialized { get; set; }

    private void InitializeOrder(Order order)
    {
        ArgumentNullException.ThrowIfNull(order);
        onOrderInitialized?.Invoke(order);
    }

    public void Process(Order order, OrderCompleted onOrderCompleted = default)
    {
        InitializeOrder(order);

        if(onOrderCompleted?.Invoke(order) == true)
        {
            
        }

    } 
}