namespace  PartialClasses;

public partial class Employee: IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public double BaseSalary {get;set;}

    public void display()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}, Email: {Email}");
    }

}