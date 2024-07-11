using Attributes;

var person = new Person("", "Hasan", 35);
if( new Validator().Validate(person) is false )
    System.Console.WriteLine("Failed to validate");
else
    System.Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old");

