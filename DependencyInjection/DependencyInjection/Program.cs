/*
# Dependency Injection #


Dependency Injection is a set of software design principles and patterns that enables you to develop
loosely coupled code.


Program to an interface, not an implementation -- Gang of Four

Loose coupling makes it extensible, and extensibility makes it maintainable. DI is nothing more
than a technique that enables loose coupling.

# Liskov Substitution Principle #

The liskov substitution principle states that we should be able to replace one implementation of an
interface without breaking either the client or the implementation.
*/


namespace DependencyInjection;
using Microsoft.Extensions.Configuration;


// Explicitly created an instance of ConsoleMessageWriter
public class Program
{
    public static void Main(string[] args)
    {
        IMessageWriter writer = new ConsoleMessageWriter();
        var salutation = new Salutation(writer);
        salutation.Exclaim();
    }
}


// Late Binding
// IConfigurationRoot confiugration = new ConfigurationBuilder()
//     .SetBasePath(Directory.GetCurrentDirectory())
//     .AddJsonFile("appsettings.json")
//     .Build();



