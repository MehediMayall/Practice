using DataTypeBasic;

// Tuples
// There are two types of tuple
// Regular tuple which is reference type and immutable <-- System.Tuple 
// Value tuple which value type and mutable <-- System.ValueTuple

var tuple1 = new Tuple<int, string>(1,"Apple");

// tuple with list
var fruits = new List<Tuple<int, string>> { 
    new Tuple<int, string>(1,"Apple"),
    new Tuple<int, string>(2,"Mango"),
    new Tuple<int, string>(3,"Orange")
};

// short form
var fruits2 = new List<(int id, string name)> { 
    (1,"Apple"),
    (2,"Mango"),
    (3,"Orange"),
};

Console.WriteLine(fruits2[2].name);

// tuple with dictionary
var minMax = new Dictionary<int, (int min, int max)>()
{
    {0, (1,9)},
    {10, (11,19)},
    {20, (21,29)},
    {30, (31,39)},
};

Console.WriteLine(minMax[20].min);
Console.WriteLine(minMax[20].max);

// tuple using class
var customers = new List<(int, Customer)>
{
    (1, Customer.Create(1, "Elon", "Musk")),
    (2, Customer.Create(2, "Zoran", "Horvat")),
    (3, Customer.Create(3, "Lex", "Fridman")),
};

