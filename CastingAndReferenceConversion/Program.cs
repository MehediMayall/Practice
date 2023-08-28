/*

Casting and Reference Conversion

An object reference can be:

1. Implicitly upcast to a base class reference
2. Explicitly downcast to a sub class reference

Upcasting:
An upcasting operation creates a base class reference from a sub class reference.

Downcasting:
A downcasting operation creates a sub class reference from a base class reference

*/


public class Asset
{
    public string Name { get; set; }
}

public class Stock: Asset
{
    public long SharesOwned;
}

public class House: Asset
{
    public decimal Mortgage;
}


public class Casting
{
    public static void print(object message) => Console.WriteLine(message);

    public static void Main(string[] args)
    {
        Stock stock = new Stock();
        stock.Name = "GP";
        stock.SharesOwned = 130;

        // Upcasting class
        Asset asset = stock;

        print(asset.Name);
        print(asset == stock);
        asset.Name = "Robi";
        print(asset.Name);
        print(stock.Name);


        // Downcasting class
        print("\r\n\r\n");

        Asset myAsset = new Asset();
        myAsset.Name = "Bashundhara";

        Stock myStock = (Stock) asset;
        myStock.SharesOwned = 100;

        print(myStock.Name);
        print(myStock.SharesOwned);


        // Downcasting using AS operator. If failed then it will return null
        print("\r\nUsing as\r\n");

        print((asset as Stock).SharesOwned);    // It will cast successfully. Result = 100;
        print((myAsset as Stock)?.SharesOwned); // will be failed but no exception Result = null


    }
}
