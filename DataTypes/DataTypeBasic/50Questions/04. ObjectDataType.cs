namespace DataTypeBasic;
using static System.Console;

 
public class ObjectKeyword
{
    public ObjectKeyword()
    {

        object name = "Mehedi Hasan";

        toUpper(name);

        name = 10;
        // name += 5;      // this won't compile
        toUpper(name);

        // assigning to a Class instance
        name = Customer.Create(1,"Mehedi", "mehedi@gmail.com");
        if (name is not null)
            WriteLine(name.ToString());

        //name.ThisMethodNotExists(); // this won't compile but will fail at runtime.

    }

    public void toUpper(object text)
    {
        if (text is string)
            WriteLine((text as string).ToUpper());
        else if(text is int)
            WriteLine(text);
    }
}

