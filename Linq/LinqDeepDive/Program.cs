using System.Collections;
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

bool EqualFrequency(string word) 
{
    Dictionary<char,int> chrs = new Dictionary<char, int>();

    foreach(char ch in word)
        if(chrs.ContainsKey(ch))
            chrs[ch] ++;
        else
            chrs[ch] = 1;

    var keys =  chrs.Keys.ToArray();
    var removedOne = false;

    for(int x=0; x< keys.Count()-1; x++)
    {
        int diff = Math.Abs(chrs[keys[x]] - chrs[keys[x+1]]);
        if(diff != 0)
            if (diff==1 && removedOne is false)
                removedOne = true;
            else 
                return false;        
    }
    
    return true;

}

WriteLine(EqualFrequency("abc"));
WriteLine(EqualFrequency("abbcc"));
WriteLine(EqualFrequency("bbbcc"));
WriteLine(EqualFrequency("bbbcccc"));