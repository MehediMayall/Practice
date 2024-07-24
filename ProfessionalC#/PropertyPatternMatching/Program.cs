Person person = new("Mehedi", "Hasan", new("Bashundhara","Dhaka"));


if ( person is Person{ Address.City: "Dhaka"} p)
    System.Console.WriteLine(p);


public record Person(string FirstName, string LastName, Address Address);
public record Address(string Street, string City);




