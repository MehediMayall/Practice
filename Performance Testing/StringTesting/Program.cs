using System.Text.RegularExpressions;
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
// BenchmarkRunner.Run<ReverseString>();

// string ReverseEachWord(string sentence)
// {
//     StringBuilder sb = new StringBuilder();
//     foreach(string st in sentence.Split(" "))
//     {
//         char[] chrs = st.ToCharArray();
//         Array.Reverse(chrs);
//         sb.Append(chrs);       
//         sb.Append(" ");
//     }
//     return sb.ToString().Trim();
// }


// string Reverse(string word)
// {
//     char[] chars = word.ToCharArray();
//     Array.Reverse(chars);
//     return new string(chars);
// }

// string ReverseEachWord(string sentence)
// {
//     string[] words = sentence.Split(' ');
//     string[] reverseWords = words.Select(Reverse).ToArray();
//     return string.Join(" ",reverseWords);
// }

// WriteLine(ReverseEachWord("sally is a great worker"));
// WriteLine(ReverseEachWord("racecar madam"));

 bool IsValid(string word) 
 {
    string str = word.ToLower();
    return 
        "aeiou".ToCharArray().Any(c=> str.Contains(c)) && 
        "abcdfgjklmnpqrstvxyz".ToCharArray().Any(c=> str.Contains(c)) &&
        str.Select(char.IsLetter).Count() >= 3 &&
        new Regex("[^A-z,0-9]").Match(str).Length == 0;
        
}

WriteLine(IsValid("234Adas"));
WriteLine(IsValid("3i"));
WriteLine(IsValid("a3$e"));