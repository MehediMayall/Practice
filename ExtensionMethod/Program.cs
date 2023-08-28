/*
## Extension Methods

Extension methods allow an existing type to be extended with new methods without altering the
definition of the original type.

An extension is a static method of a static class.
*/

public static class StringHelper
{
    public static bool IsCapitalized(this string str)
    {
        if(string.IsNullOrEmpty(str)) return false;
        return char.IsUpper(str[0]);
    }
};

public class ExtensionMethod
{
    public static void print(object message)=> Console.WriteLine(message);
    public static void Main(string[] args)
    {
        print("mehedi".IsCapitalized());
        print("Mehedi".IsCapitalized());
        print("MEHEDI".IsCapitalized());
    }
}