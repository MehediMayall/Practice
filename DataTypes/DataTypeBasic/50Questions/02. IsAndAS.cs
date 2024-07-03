namespace DataTypeBasic;

// IS keyword is used to check if an object is of a given type
// AS keyword is used to cast a variable to a given type


public class IsAndAsDemo
{
    public IsAndAsDemo()
    {
        string fruitApple = "apple";
        var fruits = (fruitApple,"mango","orange");
        
        Console.WriteLine(fruits.GetType());
        Console.WriteLine(fruits is Tuple);
        Console.WriteLine(fruits is ValueTuple);

        var fruitName =  fruits.Item1 as string;
        Console.WriteLine(fruitName);

        var anotherFruit = "Banana";
        // Nullable<int> value1 = fruits.Item1 as Nullable<int>;
        // List<int> values = anotherFruit as List<int>;

        

    }
}

