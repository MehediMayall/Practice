/*
Generics:

C# has two separate mechanisms for writting code that is reusable across different types.

A class can be generic.
A function can be generic.

*/

public class Stack<T>
{
    int Position = 0;
    T[] Data = new T[100];


    public void Push(T Item) => Data[Position++] = Item;
    public T Pop() => Data[Position--];

    // Indexer
    public T this[int index] => Data[index];
    public T[] getAll() 
    {
        T[] values= new T[Position];
        Array.Copy(Data,0,values,0,Position);
        return values;
    }

    public void printAll() {
        foreach (var item in getAll()) print(item);         
    } 
        
    private void print(object message) => Console.WriteLine(message);
}


public class Product<T>
{
    public static int Count;
}


public class Generics
{
    public static void print(object message) => Console.WriteLine(message);

    public static void Main()
    {
        // Stack<int> stack= new Stack<int>();

        // stack.Push(1);
        // stack.Push(40);
        // stack.Push(20);
        // stack.Push(100);

        // // foreach(int item in stack.getAll())
        // // {
        // //     print(item);
        // // }

        // stack.printAll();
        // stack.Pop();
        // stack.printAll();

        Stack<decimal> marks= new Stack<decimal>();
        marks.Push(58.9M);
        marks.Push(76.0M);
        marks.Push(34.5M);
        marks.Push(69.5M);

        marks.printAll();
        print(marks[0]); // 58.9       


        // Static Data
        print(++Product<int>.Count);
        print(++Product<int>.Count);
        print(++Product<string>.Count);

    }
}