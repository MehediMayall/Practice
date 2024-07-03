namespace DataTypeBasic;

// Using keyword has two main uses
// 01. using directive - which allows using types from other namespaces, and to create aliases
// 02. using statement - that defines the scope in which an IDisposable will be used, and disposed 
// at this scope's end   

using static System.Console;

using CustomerDto = DataTypeBasic.Customer;
using CustomerBase = DataTypeBasic.Customer;


public class UsingDemo
{
    public UsingDemo()
    {
        var customer1 = new CustomerDto();
        var customer2 = new CustomerBase();

        WriteLine("Using static directive");

    }
}

