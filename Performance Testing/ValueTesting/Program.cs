

using System.Diagnostics;
using static System.Console;


void rangeBetween(string str, int Count  = 10000)
{ 
    bool IsBetween = false;
    for (int x=0; x<Count; x++ ) 
        if (Enumerable.Range(1,100).Contains(str.Length))
            IsBetween = true;
}

void traditionalBetween(string str, int Count  = 10000)
{ 
    bool IsBetween = false;
    for (int x=0; x<Count; x++ ) 
        if (str.Length >=1 && str.Length <=100)
            IsBetween = true;
}

void UsingIsKeywordBetween(string str, int Count  = 10000)
{ 
    bool IsBetween = false;
    for (int x=0; x<Count; x++ ) 
        if (str.Length is >=1 and <=100)
            IsBetween = true;
}


void executeFunction(Action<string, int> action)
{
    var sw = new Stopwatch();
    sw.Start();
    action.Invoke("Check the string length between",100_000);
    sw.Stop();
    WriteLine($"{action.Method.Name} took : {sw.ElapsedMilliseconds} ms");
}

executeFunction(rangeBetween);
executeFunction(traditionalBetween);
executeFunction(UsingIsKeywordBetween);
