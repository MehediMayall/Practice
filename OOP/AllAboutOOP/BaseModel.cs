namespace AllAboutOOP;

public abstract class BaseModel
{
    public int Id { get; set;}
    public Boolean IsActive { get; set; }

    public abstract string Add();

    public void init() => System.Console.WriteLine("Hello From Base");

} 