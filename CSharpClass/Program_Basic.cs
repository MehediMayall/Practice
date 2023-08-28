using System;

namespace WineFactoryOld;

public class Wine
{
    public int Year;
    public decimal Price;
    public string? Name;

    public DateTime ExpiryDate { get; init; } = new DateTime(2024,1,30);

    public Wine(){}

    public Wine(string Name){this.Name = Name;}

    public Wine(string Name, decimal Price, int Year): this(Name) {
        this.Price = Price;
        this.Year = Year;
    }

    public void Deconstruct(out string Name, out decimal Price, out int Year){
        Name = this.Name!;
        Price = this.Price;
        Year = this.Year;
    }
}




public class WineFactory
{
    public static void MainOLD(string[] args)
    {
        Wine wine = new Wine(Name:"Pinot Noir", Price:4.5M, Year:2018);
        Console.WriteLine($"Name: {wine.Name}\n\rYear: {wine.Year}\r\nPrice: {wine.Price}");

        Wine redWine = new Wine(Name:"Syrah", Price:3.6M, Year:2020);

        // redWine.ExpiryDate = new DateTime(2023,3,31);

        // (string Name, decimal Price, int Year) = redWine;
        var(Name, Price, Year) = redWine;

        Console.WriteLine($"Name: {Name}\r\nPrice: {Price}\r\nYear:{Year}");

        Wine wine1= new Wine {
            Name = "Radikon",
            Price = 5.70M,
            Year = 2023,
            ExpiryDate = new DateTime(Year,1,30)
        };

        // wine1.ExpiryDate = new DateTime(Year,1,30);


        string str = null;
        string s = "";
        s += str?[0];
        Console.WriteLine(s);



    }  
}

