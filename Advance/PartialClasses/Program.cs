using PartialClasses;
using static System.Console;
IEmployee employee = new Employee("mehedi","hasan","mehedi@gmail.com");

employee.display();
WriteLine(employee.GetBonus());

WriteLine(employee.GetType());

IEmployee.Print();



