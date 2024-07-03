namespace DataTypeBasic;
using static System.Console;

 
public class DynamicKeyword
{
    public DynamicKeyword()
    {
        dynamic name = "Mehedi Hasan";

        toUpper(name);

        name = 10;
        name += 5;
        toUpper(name); // this will generate runtime error

        // assigning to a Class instance
        name = Customer.Create(1,"Mehedi", "mehedi@gmail.com");
        if (name is not null)
            WriteLine(name.ToString());

        // 
        // name.ThisMethodNotExists(); // this will compile but will fail at runtime.

    }

    public void toUpper(dynamic text)
    {
        if (text is string)         // checking data type. if it is string then work with that dynamic variable
            WriteLine(text.ToUpper()); // converting and printing
        else if (text is int)
            WriteLine(text);        // just printing
    }

}

