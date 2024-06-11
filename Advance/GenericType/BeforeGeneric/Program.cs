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


swap(ref p1, ref p2);

System.Console.WriteLine($"First Person Name: {p1.FirstName}");

int x=10, y=20;
swap(ref x,ref y);

System.Console.WriteLine($"X: {x}, Y: {y}");

// Boxing : converting primitive type to object type
void swap(ref object first, ref object second)
{
    object temp = first;
    first = second;
    second = temp;
}

