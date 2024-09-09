using System.Collections;
using Dumpify;
using LinqDeepDive;
using static System.Console;



// IEnumerable<int> e = GetValues();
// using IEnumerator<int> enumerator = e.GetEnumerator();

// while (enumerator.MoveNext())
// {
//     WriteLine(enumerator.Current);
// }

// IEnumerator<int> enumerator = e.GetEnumerator();

// try
// {
//     while (enumerator.MoveNext())
//     {
//         WriteLine(enumerator.Current);
//     }
// }
// finally
// {
//     enumerator?.Dispose();
// }


// static IEnumerable<int> GetValues()
// {
//     yield return 1;
//     yield return 2;
//     yield return 3;
// }

// IEnumerable<int> source = [1,2,3,4,5];
// IEnumerable<Person> source2 = [
//     new Person(){ Name = "Bangladesh", Rank=8},
//     new Person(){ Name = "India", Rank=2},
//     new Person(){ Name = "Australia", Rank=1},
// ];

// foreach(int i in Select(source, x => x * 2))
//     WriteLine(i);

// foreach(var personName in Select(source2, x => x.Name))
//     WriteLine(personName);

// static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
// {
//     foreach(var item in source)
//         yield return selector(item);
// }

// class Person
// {
//     public string Name { get; set; }
//     public int Rank { get; set; }
// }


// Deferred Execution

// List<string> countries = ["Bangladesh","Australia","Japan","India"];
// var moreThanFiveLetters = Where(countries, d=> d.Length > 5);
// var resultType = countries.Find(c=> c.Length > 5);
// var resultType2 = countries.Where(c=> c.Length > 5);


// WriteLine(resultType.GetType());
// WriteLine(resultType2.GetType());

// IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource,bool> predicate)
// {
//     foreach(var item in source)
//         if( predicate(item) )
//             yield return item;
// }

// int ScoreOfString(string str)
// {     
//     (int sum, int previous) = (0,str[0]);
//     foreach(int current in str)
//         sum += Math.Abs(previous - (previous = current));
//     return sum;
// }

// WriteLine(ScoreOfString("zaz"));

// bool EqualFrequency(string word) 
// {
//     Dictionary<char,int> chrs = new Dictionary<char, int>();

//     foreach(char ch in word)
//         if(chrs.ContainsKey(ch))
//             chrs[ch] ++;
//         else
//             chrs[ch] = 1;

//     var keys =  chrs.Keys.ToArray();
//     var removedOne = false;

//     for(int x=0; x< keys.Count()-1; x++)
//     {
//         int diff = Math.Abs(chrs[keys[x]] - chrs[keys[x+1]]);
//         if(diff != 0)
//             if (diff==1 && removedOne is false)
//                 removedOne = true;
//             else 
//                 return false;        
//     }
    
//     return true;

// }

// WriteLine(EqualFrequency("abc"));
// WriteLine(EqualFrequency("abbcc"));
// WriteLine(EqualFrequency("bbbcc"));
// WriteLine(EqualFrequency("bbbcccc"));


List<Person> people = [
    new Person{ Id = 1, Name = "Lee", Age = 36, Country ="Japan"},
    new Person{ Id = 2, Name = "Smith", Age = 46, Country = "Australia"},
    new Person{ Id = 3, Name = "Steve", Age = 46, Country = "USA"},
    new Person{ Id = 4, Name = "Mitchel", Age = 26, Country = "USA"},
    new Person{ Id = 5, Name = "Brian", Age = 26, Country = "Australia"},
    new Person{ Id = 6, Name = "Martin", Age = 26, Country = "USA"},
];

List<Person> people2 = [
    new Person{ Name = "Luic", Age = 30, Country ="Australia"},
    new Person{ Name = "Smith", Age = 46, Country = "Australia"},
    new Person{ Name = "Tina", Age = 25, Country = "USA"},
    new Person{ Name = "Christopher", Age = 32, Country = "USA"},
    new Person{ Name = "Brian", Age = 26, Country = "Australia"},
    new Person{ Name = "David", Age = 20, Country = "USA"},
    new Person{ Name = "Alex", Age = 35, Country = "England"},
];


IEnumerable<Order> orders =[
    new Order{Id = 1, PersonId=1, ProductId=1, Quantity = 2 },
    new Order{Id = 2, PersonId=3, ProductId=3, Quantity = 5 },
    new Order{Id = 3, PersonId=3, ProductId=4, Quantity = 1 },
    new Order{Id = 4, PersonId=4, ProductId=1, Quantity = 10 },
];

IEnumerable<int> nums =  Enumerable.Range(1,15);
IEnumerable<int> nums2 =  Enumerable.Range(10,15);

IEnumerable<List<int>> table = [Enumerable.Range(1,20).ToList(), Enumerable.Range(1,20).ToList()];
// IEnumerable<int> collection = [1,2,3,4,5,6];
// collection.Dump();
// collection.Where(x=> x>2).Dump();

// OfType
// IEnumerable<object> items = ["mehedi",2,5,3,"hasan", true];
// items.OfType<int>().Dump();
// items.OfType<string>().Dump();
// items.OfType<bool>().Dump();

// IEnumerable<int> numbers = items.OfType<int>();
// numbers.Dump();

// Skip
// nums.Skip(3).Dump();
// nums.Skip(3).Take(5).Dump();

// Skip last
// nums.SkipLast(3).Dump();
// nums.TakeLast(3).Dump();

// Skip while
// nums.SkipWhile(x => x < 10).Dump();
// nums.TakeWhile(x => x < 10).Dump();

// Select
// nums.Select(x => x).Dump();
// nums.Select(x => x.ToString().PadLeft(3)).Dump();
// nums.Select((x, index) => $"{index.ToString().PadLeft(2)} -> {x.ToString().PadLeft(3)}").Dump();

// table.Select(x => x).Dump();
// table.SelectMany(x => x).Dump();
// table.SelectMany(x => x.ToString()).Dump();
// table.SelectMany(x => x.Select(y => y.ToString())).Dump();
// table.SelectMany((x,index) => x.Select(y => $"{index} -> {y.ToString()}")).Dump();

// Cast
// IEnumerable<object> objects = [1,2,3,4,5,6,7,8,9];
// objects.Cast<int>().Dump();

// Chunk
// nums.Chunk<int>(10).Dump();


// Existance or Quantity Checkes
// Any, All, Contains --- these are executed immediately

// nums.Any(x => x > 2).Dump();
// nums.All(x => x > 2).Dump();
// nums.Contains(3).Dump();

// Sequence Methods
// nums.Append(16).Dump();
// nums.Prepend(0).Dump();


// Aggregation Methods
// nums.Count().Dump();
// nums.Where(x => x > 10).Count().Dump();
// nums.Max().Dump();
// nums.Max(x => x * -1).Dump();
// nums.MaxBy(x => x * -1).Dump();

// nums.Min().Dump();
// nums.Min(x => x< 10 ).Dump();
// nums.MinBy(x => x <10).Dump();

// nums.Sum().Dump();

// nums.Aggregate((x,y) => x + y).Dump();
// nums.Aggregate(100,(x,y) => x + y).Dump();
// nums.Aggregate(0,(x,y) => x + y, x => x / 2).Dump();
// nums.Select(x => x.ToString()).Aggregate((x,y) => $"{x}, {y}").Dump();

// nums.First().Dump();
// nums.FirstOrDefault().Dump();
// nums.Where(x => x>100).FirstOrDefault(-1).Dump();
// nums.LastOrDefault().Dump();

// nums.ElementAt(1).Dump();
// nums.ElementAtOrDefault(12).Dump();


// nums.ToArray().Dump();
// nums.ToDictionary(key => key, value => value * 2).Dump();
// nums.ToList().Dump();
// nums.ToHashSet().Dump();

// Lookup
// people.ToLookup(x => x.Age).Dump();
// people.ToLookup(x => x.Age)[26].Dump();
// people.ToLookup(x => x.Age)[26].FirstOrDefault().Name.Dump();

// people.ToLookup(x => x.Country).Dump();
// people.ToLookup(x => x.Country)["USA"].Dump();


// IEnumerable
// IEnumerable<Person> people2 = people.AsEnumerable();
// people2.GetType().Dump();


// Join

// nums.Union(nums2).Dump("Union");
// nums.Intersect(nums2).Dump("Intersect");
// nums.Except(nums2).Dump("Except");


// people.UnionBy(people2, person => person.Name).Dump("Union by person name");
// people.UnionBy(people2, person => person.Country).Dump("Union by country");
// people.UnionBy(people2, person => person.Age).Dump("Union by age");

// people.IntersectBy(people2.Select(p=> p.Name), person => person.Name).Dump("Intersected by person name");
// people.IntersectBy(people2.Select(p=> p.Age), person => person.Age).Dump("Intersected by person age");
// people.IntersectBy(people2.Select(p=> p.Country), person => person.Country).Dump("Intersected by person country");


// people.ExceptBy(people2.Select(p=> p.Name), person => person.Name).Dump("Except by person name");
// people.ExceptBy(people2.Select(p=> p.Age), person => person.Age).Dump("Except by person age");
// people.ExceptBy(people2.Select(p=> p.Country), person => person.Country).Dump("Except by person country");


// SequenceEqual


// Joining & grouping

// people.Zip(people2).Dump("Zip");
// people.Zip(people2).FirstOrDefault().Dump("Zip");
// people.Zip(people2).LastOrDefault().Dump("Zip");


// people.Join(people2, 
//     person1 => person1.Country, 
//     person2 => person2.Country,
//     (person1, person2) => new{
//         person1.Id,
//         person1.Country,
//         person1.Name
//     }).Dump();

// people.Join(orders, 
    
//     person => person.Id, 
//     order => order.PersonId, 

//     (person, order) => new{
//         person.Name, 
//         order.ProductId, 
//         order.Quantity
//     }
// ).Dump();


// people.GroupJoin(orders, 
    
//     person => person.Id, 
//     order => order.PersonId, 

//     (person, order) => new{
//         person.Id,
//         person.Name, 
//         order
//     }
// ).Dump();


// people.GroupBy(p=> p.Age).Dump("Group by Age");
// people.GroupBy(p=> p.Country).Dump("Group by Country");


// var result = from person in people
//     join order in orders 
//     on person.Id equals order.PersonId
//     select new {
//         person.Id,
//         person.Name,
//         order.ProductId,
//         order.Quantity
//     };

// result.Dump();

// var personOrderList = from person in people
//     join order in orders
//     on person.Id equals order.PersonId    
//     into personOrders
//     select new {
//         person.Name,
//         orders = personOrders
//     };

// personOrderList.Dump();

// Total Product
// var personProductCount = from person in people
//     join order in orders
//     on person.Id equals order.PersonId    
//     into personOrders
//     select new {
//         person.Name,
//         TotalQuantity = personOrders.Sum(o=> o.Quantity)
//     };

// personProductCount.Dump();


// Total Order Count
// var personOrderCount = from person in people
//     join order in orders
//     on person.Id equals order.PersonId    
//     into personOrders
//     select new {
//         person.Name,
//         TotalOrder = personOrders.Count()
//     };

// personOrderCount.Dump();

// Person product wise quantity total
// var personOrderList = from person in people
//     join order in orders
//     on person.Id equals order.PersonId    
//     into personOrders
//     select new 
//     {
//         person.Name,
//         Orders = personOrders
//     };

// Inner join
// var orderPersonOnly = from person in people
//     join order in orders
//     on person.Id equals order.PersonId  
//     select new {
//         Name = person.Name,
//         orderId = order.Id
//     };
// orderPersonOnly.Dump();

// Left join
// var personOrderList = from person in people
//     join order in orders
//     on person.Id equals order.PersonId into personOrders
//     from  order in  personOrders.DefaultIfEmpty()
//     select new {
//         Name = person.Name,
//         orderId = order != null ? order.Id : 0
//     };

// personOrderList.Dump();

// var personOrderList2 = people.Join(orders, 
//     person => person.Id, 
//     order => order.PersonId,
//     (person, order)=> new {
//         person.Name,
//         order.Id
//     });

// personOrderList2.Dump();


// var personOrderList = from person in people
//     join order in orders 
//     on person.Id equals order.PersonId into personOrders
//     from order in personOrders.DefaultIfEmpty()
//     select new {
//         Name = person.Name,
//         OrderId = order != null ? order.Id : 0
//     };

// personOrderList.Dump();

// CONSOLE MAGIC

// Adding 20% VAT with each one
// Console.ReadLine()
//     .Split(new string[]{","}, StringSplitOptions.RemoveEmptyEntries)
//     .Select(double.Parse)
//     .Select(n => n * 1.2)
//     .ToList()
//     .ForEach(n => Console.WriteLine($"{n}"));

// Console.ReadLine()
//     .Split(" ")
//     .Select(s=> s.ToUpper())
//     .ToList()
//     .ForEach(s=> Console.WriteLine(s));

string input = "2 5 6 test abc 6.3 -3 false";
var numbers = input.Split(" ")
    .Select(n=> {
        long value;
        bool success = long.TryParse(n, out value);
        return new{value, success};
    })
    .Where(n=> n.success)
    .Select(x => x.value)
    .ToList();

numbers.Dump();
