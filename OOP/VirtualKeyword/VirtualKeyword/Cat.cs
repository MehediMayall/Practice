namespace VirtualKeyword;

public class Cat: Animal
{
    public Cat(string Name, int Age): base(Name, Age)
    {
        
    }

    public override string GetName()
    {
        throw new NotImplementedException();
    }
}