

using System.Diagnostics;
using System.Text;
using static System.Console;


void concatUsingPlus(int Count  = 10000)
{
    string tempString = "";

    for (int x=0; x<Count; x++ ) 
        tempString+= x.ToString();

    // WriteLine(tempString);
}

void concatUsingStringBuilder(int Count = 10000)
{
    StringBuilder sb = new StringBuilder();

    for (int x=0; x<Count; x++ ) 
        sb.Append(x.ToString());

    string tempString = sb.ToString();
    // WriteLine(tempString);
}

void executeFunction(Action<int> action)
{
    var sw = new Stopwatch();
    sw.Start();
    action.Invoke(100_000);
    sw.Stop();
    WriteLine($"{action.Method.Name} took : {sw.ElapsedMilliseconds} ms");
}

executeFunction(concatUsingPlus);
executeFunction(concatUsingStringBuilder);
