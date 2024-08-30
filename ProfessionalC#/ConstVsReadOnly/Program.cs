using static System.Console;


Employee employee = new(0.05M);

// this code will not compile. 
// Member 'Employee.Bonus' cannot be accessed with an instance reference; qualify it with a type name instead
// WriteLine(employee.Bonus); 

// This is possible. Readonly fields are instance variable
WriteLine(employee.YearlyBonus);

// This is possible. Every constant is a class variable (by default static) 
WriteLine(Employee.Bonus);

// This is not possible. Readonly field are not static / class variable
// WriteLine(Employee.YearlyBonus);


class Employee
{
    // These are instance variables
    public int Id { get; set; }
    public string Fullname { get; set; }

    // This is not a instance variable. 
    // We need property accessor to read and write value of this variable
    public const decimal Bonus = 0.05M;

    // This won't be compiled
    // public const decimal MonthlyBonus {get;}  = 0.01M;

    public readonly decimal YearlyBonus = 0.05M;

    public Employee(decimal YearlyBonus)
    {
        const decimal Bonus = 0.05M;

        // This is possible
        this.YearlyBonus = YearlyBonus;

        // This is not possible
        // Employee.Bonus = YearlyBonus;
    }

    public void PrintBonus()
    {
        // Not possible (Not a instance variable)
        // WriteLine(this.Bonus); 

        // This is possible
        WriteLine(this.YearlyBonus);
    }
}


