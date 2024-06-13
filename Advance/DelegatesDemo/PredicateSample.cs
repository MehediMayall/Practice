namespace DelegatesDemo;

// A Func is by default a delegate. It's a shorter version of delegate  
// which takes 1 input paramter and return bool values
public class PredicateSample
{
    public static void Show()
    {
        int[] numbers = {1,2,3,4,5,6,7,8,9,10,11};

        // using defined predicate
        Predicate<int> isEven = IsEven;
        int[] evenNumbers = GetEvenNumbers(numbers, isEven);
        foreach (int number in evenNumbers) System.Console.WriteLine(number);
    }

    public static int[] GetEvenNumbers(int[] Numbers, Predicate<int> predicate)
    {
        return Numbers.Where(x => predicate(x)).ToArray<int>();
    }

     
    static bool IsEven(int x) => x % 2 == 0;
    static bool IsLowerCase(string str) => str.Equals(str.ToLower());

}