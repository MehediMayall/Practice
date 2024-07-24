using IEqualityComparers;
using static System.Console;


List<Person> people = new List<Person>{
    new Person{ Id=1, FullName="Mehedi Hasan", Email="mehedi@gmail.com"},
    new Person{ Id=2, FullName="Mehedi Hasan", Email="mehedi@gmail.com"},
    new Person{ Id=3, FullName="Ali Hasan", Email="ali@gmail.com"},
};

// Default comparer
var distinctPerson = people.Distinct().ToList();

foreach(Person person in distinctPerson)
    WriteLine($"Id: {person.Id}, Name: {person.FullName}, Email: {person.Email}");


WriteLine("\n After using custom person comparer \n");

// Using given comparer
var distinctPerson2 = people.Distinct(new PersonComparer()).ToList();

foreach(Person person in distinctPerson2)
    WriteLine($"Id: {person.Id}, Name: {person.FullName}, Email: {person.Email}");

