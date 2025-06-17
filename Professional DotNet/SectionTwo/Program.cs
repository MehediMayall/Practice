using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using Dumpify;
using SectionTwo;
using static System.Console;

var text = "Mehedi Hasan";

// int distinctCharacterCount = text.Distinct().Count();
// distinctCharacterCount.Dump();

// Finding the number of repeating character
// var frequencies = text
//     .GroupBy(x => x)
//     .Select(x => new { Character = x.Key, Count = x.Count()});

// frequencies.Dump();


// String to encoding

byte[] data = Encoding.UTF8.GetBytes(text);
// data.Dump();

byte[] data32 = Encoding.UTF32.GetBytes(text);

// data32.Dump();


// Write to file
// File.WriteAllBytes("utf-8.txt", data);
// File.WriteAllBytes("utf-32.txt", data32);

// Encoded data to string

var strFromUTF8Data = Encoding.UTF8.GetString(data);
var strFromUTF32Data = Encoding.UTF8.GetString(data32);

// strFromUTF8Data.Dump("UTF-8");
// strFromUTF32Data.Dump("UTF-32");

// Reading file using encoding
// var contentUTF8 = File.ReadAllText("utf-8.txt", Encoding.UTF8);
// contentUTF8.Dump("From file utf8");


// Count occurences of a character

// text.Count(x => x == 'a').Dump();
// text.Count(
//     x => string.Equals(x.ToString(), "a", StringComparison.CurrentCulture)
// ).Dump();



// string sometext = new String().New("Hello");

// partial class String
// {
//     public string New(string str) => str;
// }

// var dateString = "2021-01-09 11:11:12";

// DateTime.ParseExact(dateString, "yyyy-MM-dd", new CultureInfo("en-US")).Dump();


// Array to Dictionary

// var fruits = new[]
// {
//     new Fruit(){ Id =1, Name = "Apple"},
//     new Fruit(){ Id =2, Name = "Mango"},
//     new Fruit(){ Id =3, Name = "Banana"},
// };

// var fruitDict = fruits.ToDictionary(x=> x.Id, y => y.Name);
// fruitDict.Dump();

// foreach(KeyValuePair<int,string> kvp in fruitDict)
//     WriteLine($"Key: {kvp.Key}, value: {kvp.Value}");



// class Fruit
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
// }

// var entity = new ExtendedEntity()
// {
//     Name = "Mehedi"
// };

// entity.Name.Dump();
// entity.BaseEntity.Name.Dump("Name from base entity");


// var groceryList = new ReadOnlyCollection<string>(new List<string>{"Apple", "Banana"});

// var x = 5;
// WriteLine(4 & 5);

// Union

// int[] list1 = Enumerable.Range(1,10).ToArray();
// int[] list2 = Enumerable.Range(7,10).ToArray();


// var list3 = list1.Union(list2);
// list3.GetType().Name.Dump();
// list1.Dump();
// list3.Dump();


// Array Covariance

string[] names = new string[]{
    "Australia",
    "Bangladesh"
};

object[] objects = names;

objects.First().GetType().Dump();


// Reflection

// Assembly.GetExecutingAssembly().GetTypes().Dump();

// foreach(var type in Assembly.GetExecutingAssembly().GetTypes())
//     // type.Name.Dump();
//     type.GetConstructors().FirstOrDefault().GetParameters().Dump();

// foreach(var assembly in Assembly.GetExecutingAssembly().GetTypes())
// {
//     var obj = Activator.CreateInstance(assembly.GetType());
//     obj.GetType().Dump();
// }

// typeof(int).Assembly.FullName.Dump();
// typeof(int).Assembly.Location.Dump();

// Creating object and setting property value

// var typeOfClassy = typeof(Classy);

// var classy  = new Classy();
// var prop = typeOfClassy.GetProperty("Propertua");
// prop.SetValue(classy, "Value for propertua");

// classy.Dump();

// class Classy{
//     public string Propertua { get; set; }
// }



