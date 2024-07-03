using System.Text.Json;

namespace CollectionDemo;

public class DictionaryDemo
{
    List<Employee> employees;
    Dictionary<string, Employee> employeesInKeys;
    Dictionary<string, Employee> countryWiseEmployees;

    public DictionaryDemo()
    {
        using(StreamReader sr = new StreamReader("MOCK_DATA.json"))
        {
            var json = sr.ReadToEnd();
            employees = JsonSerializer.Deserialize<List<Employee>>(json);
            employeesInKeys = employees.ToDictionary(e=> e.email, StringComparer.OrdinalIgnoreCase);
            // countryWiseEmployees = employees.ToDictionary(e=> e.country);
        }
    }

    public void Show()
    {
        employeesInKeys.TryGetValue("cbeckittx@fema.gov".ToUpper(),out Employee employee);
        if (employee != null) System.Console.WriteLine(employee);
    }
}