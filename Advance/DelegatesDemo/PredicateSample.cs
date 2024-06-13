namespace DelegatesDemo;

// A Func is by default a delegate. It's a shorter version of delegate  
// which takes 1 input paramter and return bool values
public class PredicateSample
{
    public static void Show()
    {
        int[] numbers = {1,2,3,4,5,6,7,8,9,10,11};

        // // using defined predicate
        Console.WriteLine("Printing Even Numbers Using Predicate Delegate");
        Predicate<int> isEven = IsEven;
        int[] evenNumbers = GetEvenNumbers(numbers, isEven);
        foreach (int number in evenNumbers) Console.WriteLine(number);



        // using Func
        Console.WriteLine("\nPrinting Odd Numbers Using Func Delegate");
        Func<int, bool> funcPredicate = IsOdd;
        int[] oddNumbers = GetOddNumbers(numbers, funcPredicate);
        foreach (int number in oddNumbers) Console.WriteLine(number);


        // using anonymous predicate
        Console.WriteLine("\nPrinting Even Numbers Using Anonymous Predicate Delegate");
        int[] evenNumbers2 = GetEvenNumbers(numbers, delegate(int x) {return x % 2 == 0;});
        foreach (int number in evenNumbers2) Console.WriteLine(number);
    }

    public static int[] GetEvenNumbers(int[] Numbers, Predicate<int> predicate)
    {
        return Numbers.Where(x => predicate(x)).ToArray<int>();
    }
    public static int[] GetOddNumbers(int[] Numbers, Func<int, bool> predicate)
    {
        return Numbers.Where(predicate).ToArray<int>();
    }

     
    static bool IsEven(int x) => x % 2 == 0;
    static bool IsOdd(int x) => x % 2 != 0;
    static bool IsLowerCase(string str) => str.Equals(str.ToLower());

}