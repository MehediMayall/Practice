using BenchmarkDotNet.Running;
using StringTesting;

// void concatUsingPlus(int Count  = 10000)
// {
//     string tempString = "";

//     for (int x=0; x<Count; x++ ) 
//         tempString+= x.ToString();

//     // WriteLine(tempString);
// }

// void concatUsingStringBuilder(int Count = 10000)
// {
//     StringBuilder sb = new StringBuilder();

//     for (int x=0; x<Count; x++ ) 
//         sb.Append(x.ToString());

//     string tempString = sb.ToString();
//     // WriteLine(tempString);
// }

// void executeFunction(Action<int> action)
// {
//     var sw = new Stopwatch();
//     sw.Start();
//     action.Invoke(100_000);
//     sw.Stop();
//     WriteLine($"{action.Method.Name} took : {sw.ElapsedMilliseconds} ms");
// }

// executeFunction(concatUsingPlus);
// executeFunction(concatUsingStringBuilder);


// var reverseString = new ReverseString();

// WriteLine(reverseString.ReverseUsingSystemFunction("Hello"));
// WriteLine(reverseString.ReverseUsingStack("Hello"));
// WriteLine(reverseString.ReverseUsingLoop("Hello"));
// WriteLine(reverseString.ReverseRecursively("Hello"));
// WriteLine(reverseString.ReverseUsingTwoPointer("Hello"));

// Benchmark of Reverse string
BenchmarkRunner.Run<ReverseString>();

