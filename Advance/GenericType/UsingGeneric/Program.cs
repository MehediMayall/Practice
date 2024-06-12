using GenericType;

Person p1 = new Person{
    FirstName = "Mehedi",
    LastName = "Hasan",
    Age = 35,
};

Person p2 = new Person{
    FirstName = "Virat",
    LastName = "Kohli",
    Age = 35,
};


swap<Person>(ref p1, ref p2);

System.Console.WriteLine($"First Person Name: {p1.FirstName}");

int x=10, y=20;
swap<int>(ref x,ref y);

System.Console.WriteLine($"X: {x}, Y: {y}");

// Using Generic Type in Method Signature
void swap<T>(ref T first, ref T second)
{
    T temp = first;
    first = second;
    second = temp;
}

