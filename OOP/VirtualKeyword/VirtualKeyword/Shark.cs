namespace VirtualKeyword;

public class Shark : Animal
{
    public Shark(string Name, int Age): base(Name, Age)
    {
        
    }
    public override string GetName()
    {
        throw new NotImplementedException();
    }
}