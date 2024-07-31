using System.Diagnostics;
using static System.Console;

int[] numbers = new int[100000];

void print(string message, int[] numbers) 
{
    // WriteLine($"{message}:");
    // foreach(int x in numbers)
    //     Write(x.ToString().PadLeft(3));
    // WriteLine("");
}


// Using HashSet
void printDuplicateUsingHashSet()
{
    WriteLine("\nUsing HashSet::\n");

    HashSet<int> distincts = new(), duplicates = new();

    foreach(int x  in numbers)
        if (!distincts.Add(x))
            duplicates.Add(x);

    print("Distinct Numbers", distincts.ToArray());
    print("Duplicate Numbers", duplicates.ToArray());
}


// Using Dictionary 
void printDuplicateUsingDictionary()
{
    WriteLine("\nUsing Dictionary::\n");

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

    print("Distinct Numbers", distincts.ToArray());
    print("Duplicate Numbers", duplicates.ToArray());
}


// Using Linq
void printDuplicateUsingLinq()
{
    WriteLine("\nUsing Linq::\n");

    int[] duplicates = numbers
        .GroupBy(x=> x)
        .Where(g=> g.Count() > 1)
        .Select(g=> g.Key)
        .ToArray();

    int[] distincts = numbers.Distinct().ToArray();

    print("Distinct Numbers", distincts.ToArray());
    print("Duplicate Numbers", duplicates.ToArray());
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
    numbers[x] = new Random().Next(1,9999);

executeFunction(printDuplicateUsingHashSet);
executeFunction(printDuplicateUsingDictionary);
executeFunction(printDuplicateUsingLinq);

