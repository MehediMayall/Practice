// String
string name1 = "Mehedi Hasan";
string name2 = "Mehedi Hasan";


Console.WriteLine($"\nString: {name1 == name2}");
Console.WriteLine(name1.GetHashCode());
Console.WriteLine(name2.GetHashCode());

// Integer
int value1 = 10;
int value2 = 10;

Console.WriteLine($"\nInteger: {value1 == value2}");
Console.WriteLine(value1.GetHashCode());
Console.WriteLine(value2.GetHashCode());

// Decimal
decimal amount1 = 10;
decimal amount2 = 10;

Console.WriteLine($"\nDecimal: {amount1 == amount2}");
Console.WriteLine(amount1.GetHashCode());
Console.WriteLine(amount2.GetHashCode());

// DateTime
DateTime today = DateTime.Now;
DateTime yesterday = DateTime.Now.AddDays(-1);

Console.WriteLine($"\nDateTime: {today == yesterday}");
Console.WriteLine(today.GetHashCode());
Console.WriteLine(yesterday.GetHashCode());

// Integer Array
int[] valueArray1 = { 1,3,4,5,6,7,8};
int[] valueArray2 = { 1,3,4,5,6,7,8};

Console.WriteLine($"\nInt Array: {valueArray1 == valueArray2}");
Console.WriteLine($"SequenceEqual(): {valueArray1.SequenceEqual(valueArray2)}");

Console.WriteLine(valueArray1.GetHashCode());
Console.WriteLine(valueArray2.GetHashCode());


// List of Integer
List<int> valueList1 = new List<int>{ 1,3,4,5,6,7,8};
List<int> valueList2 = new List<int>{ 1,3,4,5,6,7,8};

Console.WriteLine("\nList before add:");
Console.WriteLine($"Int List: {valueList1 == valueList2}");
Console.WriteLine($"SequenceEqual(): {valueList1.SequenceEqual(valueList2)}");
Console.WriteLine(valueList1.GetHashCode());
Console.WriteLine(valueList2.GetHashCode());

Console.WriteLine("\nList after add:");
valueList1.Add(9);
valueList2.Add(9);
Console.WriteLine($"Int List: {valueList1 == valueList2}");
Console.WriteLine($"SequenceEqual(): {valueList1.SequenceEqual(valueList2)}");

Console.WriteLine(valueList1.GetHashCode());
Console.WriteLine(valueList2.GetHashCode());


