using System.Diagnostics;
using static System.Console;

int[] numbers = new int[100000];


// Using HashSet
void printDuplicateUsingHashSet()
{
    HashSet<int> distincts = new(), duplicates = new();

    foreach(int x  in numbers)
        if (!distincts.Add(x))
            duplicates.Add(x);

    WriteLine($"Duplicates: {duplicates.Count()}");
}


// Using Dictionary 
void printDuplicateUsingDictionary()
{
    Dictionary<int,int> duplicateCount = new();
    foreach(int x in numbers)
        if (duplicateCount.ContainsKey(x))
            duplicateCount[x]++;
        else
            duplicateCount[x] = 1;

    int[] duplicates = duplicateCount
        .Where(x=> x.Value > 1)
        .Select(x=> x.Key)
        .ToArray();

    int[] distincts = duplicateCount.Keys.ToArray();
    WriteLine($"Duplicates: {duplicates.Count()}");
}


// Using Linq
void printDuplicateUsingLinq()
{
    int[] duplicates = numbers
        .GroupBy(x=> x)
        .Where(g=> g.Count() > 1)
        .Select(g=> g.Key)
        .ToArray();

    int[] distincts = numbers.Distinct().ToArray();
    WriteLine($"Duplicates: {duplicates.Count()}");
}

void countDuplicateUsingLinq()
{
    int duplicates = numbers
        .GroupBy(x=> x).Count();    
    WriteLine($"Duplicates: {duplicates}");
}


void executeFunction(Action action)
{
    var sw = new Stopwatch();
    sw.Start();
    action.Invoke();
    sw.Stop();
    WriteLine($"{action.Method.Name.Split('_').Last()} took : {sw.ElapsedMilliseconds} ms");
}

for(int x=0;x<100000;x++)
    numbers[x] = new Random().Next(9,99999);

executeFunction(printDuplicateUsingHashSet);
executeFunction(printDuplicateUsingDictionary);
executeFunction(printDuplicateUsingLinq);
executeFunction(countDuplicateUsingLinq);

