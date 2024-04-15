namespace VirtualKeyword;

public abstract class Animal
{
    public Animal(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract string GetName();
    public virtual void Walk()
    {
        System.Console.WriteLine($"{Name} is walking");
    }
} 