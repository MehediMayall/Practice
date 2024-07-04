// What is lambda expression?
// A lambda expression is a special way of defining annonymous function

// param => expression
// Expression lambdas:  (input-parameters) => expression
// Statement lambdas:   (input-parameters) => { <sequence-of-statement> }


using static System.Console;

namespace DataTypeBasic;
public class LambdaExpressions
{
    int[] numbers = {1,2,3,4,5,6,7,8,9,10};
    public LambdaExpressions()
    {
         var evenNumbers = numbers.Filter(n=> n % 2 == 0);  // lambda expression
         foreach(var num in evenNumbers)
            WriteLine(num);
    }
}

public static class FilterNumbers
{
    public static IEnumerable<int?> Filter(this int[] Numbers, Func<int, bool> predicate)
    {
        foreach(int x in Numbers)
            if(predicate(x))        // annonymous function calling
                yield return x;     // using yield to provide iterator to the client
    }
}
