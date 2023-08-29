/*
## Enum   

An enum is a special value type that lets you specify a group of named numeric constants.

*/

public enum Borders: byte
{
    Left = 1,
    Right = 2,
    Top = 3,
    Bottom = 4
}

public class Enums
{
    public static void print(object message) => Console.WriteLine(message);
    public static void Main(){
                
        print(Borders.Left);
    }
}