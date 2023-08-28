/*
Instance Method Chaining

*/

public class Calculator
{
    public double Number1 { get; set; } = 0;
    public Calculator(){}
    public Calculator(double Number): base() => Number1 = Number;
    public void print(object message) => System.Console.WriteLine(message);


    public Calculator Show()
    {
        print($"Result= {Number1}");        
        return this;
    }
    public Calculator ShowInt()
    {
        print($"Result= {(int)Number1}");        
        return this;
    }

    public Calculator Add(double Number2){
        Number1 = Number1 + Number2;  
        return this;
    }

    public Calculator Subtract(double Number2){
        Number1 = Number1 - Number2;
        return this;
    }

    public Calculator Divide(double Number2){
        Number1 = Number1 / Number2;
        return this;
    }

    public Calculator Multiply(double Number2){
        Number1 = Number1 * Number2;
        return this;
    }
    
}

public class Program
{
    public static void Main(string[] args)
    {
        var c = new Calculator(30);
        c.Add(10).Subtract(5).Multiply(3).Divide(4.4).Show();

        var c2 = new Calculator(0);
        c2.Add(100).Divide(3).ShowInt();

        var c3 = new Calculator(0);
        c3.Add(20).Multiply(4).ShowInt();

        
        invoice.Validate().HasThisDuplicateInvoice().

        var product = new Product();

    }


}

public class Prdouct
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }

    public Product AddStock(int quantity)
    {
        this.Quantity = this.Quantity + quantity;
        return this;
    }

    public Product SubtarctStock(int quantity)
    {
        this.Quantity = this.Quantity + quantity;
        return this;
    }
}

Order <- OrderProcessor;

