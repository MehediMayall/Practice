namespace  PartialClasses;

public partial class Employee: IEmployee
{
    public Employee(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        BaseSalary = 1_20_000;
    }

    public double GetBonus() => BaseSalary * 0.10;

}