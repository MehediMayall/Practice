namespace OrderProcessorDelegates;

public class Order
{
    public Guid Id { get;} = Guid.NewGuid();
    public string CustomerName { get; set; }

    public double NetAmount { get; set; }
}