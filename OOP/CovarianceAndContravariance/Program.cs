using CovarianceAndContravariance;
using static System.Console;


// void BreakingLSP()
// {
//     BagOfApples bagOfApples = new BagOfApples();

//     bagOfApples.Add(new Apple{ Name = "Red Apple"});
//     // bagOfApples.Add(new Banana{ Name = "Blue Java"});

//     WriteLine(bagOfApples.Get(0).Name);
//     // WriteLine(bagOfApples.Get(1).Name);
// }

void WithStandardGenerics()
{
    List<Apple> bagOfApples = new List<Apple>()
    {
        new Apple { Name = "Granny Smith"},
        new Apple { Name = "Cox's Orange Pippin"},
        new Apple { Name = "Golden Delicious"}
    };

    IEnumerable<Fruit> bagOfFruit;
    bagOfFruit = bagOfApples;

    foreach(Fruit fruit in bagOfFruit)
        WriteLine(fruit.Name);

    bagOfApples.Add(new Apple{ Name = "Braeburn"});
    WriteLine("\nAfter adding Braeburn: ");

    foreach(Fruit fruit in bagOfFruit)
        WriteLine(fruit.Name);

    // We can't do
    // bagOfApples.Add(new Banana{ Name = "Blue Java"});
    // bagOfFruit.Add(new Banana{ Name = "Blue Java"});

}

void WithCustomGeneric()
{
    Bag<Apple> bagOfApples = new Bag<Apple>();
    bagOfApples.Add(new Apple { Name = "Granny Smith"});
    bagOfApples.Add(new Apple { Name = "Cox's Orange Pippin"});
    bagOfApples.Add(new Apple { Name = "Golden Delicious"});
    
    IBag<Fruit> bagOfFruit = bagOfApples;

    WriteLine(bagOfFruit.Get(0).Name);
    WriteLine(bagOfFruit.Get(1).Name);

    // We can't do
    // bagOfApples.Add(new Banana{ Name = "Blue Java"});
    // bagOfFruit.Add(new Banana{ Name = "Blue Java"});
}



WithCustomGeneric();
// WithStandardGenerics();
// BreakingLSP();
