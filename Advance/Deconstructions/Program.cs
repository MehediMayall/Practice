using Deconstructions;

var person = new Person("Mehedi", "Hasan",35);
var(firstName, lastName, age) = person;

Console.WriteLine($"FirstName: {firstName}, LastName: {lastName}, Age: {age}");

var dateTime = DateTime.Now;

var( year, month, day) = dateTime.Date;

System.Console.WriteLine($"{year}, {month}, {day}");
