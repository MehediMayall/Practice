/*
## Records

A record is a special kind of class or sturct that is designed to work well with immutable(readonly) data.
Its most useful feature is nondestructive mutation.

Records are suitable for representing data. Record should not be used for business logic.

In object-oriented and functional programming, an immutable object is an object whose state
can not be modified after it is created.


# Record type generated functionality:

> Value-based equality check
> GetHashCode
> Copy & Clone
> PrintMembers and ToString
> Deconstruct
> Serialize and Deserialize

Records are thread safe because of its immutable.

record Customer();

record class Customer();        // Reference type record

record struct Customer();           // Value type record

record Customer(string Firstname, string Lastname);

*/


using System.Text.Json;

public class Program
{
    public static void print(object message) => Console.WriteLine(message);
    record Customer(string Firstname, string Lastname);

    public static void Main(string[] args)
    {
        var customer = new Customer("Mehedi","Hasan");
        var customer2 =new Customer("Mehedi","Hasan");
        var customer3 =new Customer("Mehedi","");
        
        print(customer.Firstname);

        // Value-base equality
        print(customer == customer2);
        print(customer == customer3);

        // GetHashCode
        print(customer.GetHashCode());

        // Copy & Clone
        var customerX = customer;
        print(customerX.Firstname);

        // Deconstruct
        (string Firstname, string Lastname) = customer;
        print((Firstname, Lastname));

        // PrintMembers and Tostring()
        print(customer.ToString());

        // Serialize and Deserialize
        var customerInJSON = JsonSerializer.Serialize(customer, options: new(){ WriteIndented = true});
        print(customerInJSON);

        Customer customerFromJSON = JsonSerializer.Deserialize<Customer>("""{"Firstname":"Rahat","Lastname":"Hossain"}""");
        print(customerFromJSON?.Firstname);


    }

}

