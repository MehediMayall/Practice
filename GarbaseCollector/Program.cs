public class Employee
{
    public Guid Guid { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Email { get; set; }
    public string Remarks = "";

    public DateTime DateOfBirth{ get; set; }
}

public class GarbaseCollector
{

    public static void Main(string[] args)
    {



        List<Employee> employees = new List<Employee>();  

        for(int i = 0;i<10000000;i++)
        {
            Employee employee = new Employee{
                Guid = Guid.NewGuid(),
                FirstName = DateTime.Now.ToString(),
                LastName = DateTime.Now.ToString(),
                Email = DateTime.Now.ToString(),
                DateOfBirth = DateTime.Now,
                Remarks = "She had spoken to one woman who'd jumped over a seawall into the ocean, where she remained for seven hours to escape the flames. The woman’s neighbour died next to her in the water, she said."
            };

            employees.Add(employee);
        }

        foreach(Employee employee in employees){
            Console.WriteLine(employee.FirstName, employee.LastName, employee.Email);
        }


        Console.ReadLine();
        GC.Collect();
        Console.ReadLine();
    }

}

