using System.Text.Json;

namespace LinqDemo;


public class MethodSyntax
{
    public IList<Container> containers;

    public MethodSyntax()
    {
        // Load Data;
        string path = Path.Combine(Environment.CurrentDirectory, "data");
        using(StreamReader sr = new StreamReader(Path.Combine(path, "container.json")))
        {
            string jsonString = sr.ReadToEnd();
            containers = JsonSerializer.Deserialize<List<Container>>(jsonString);
            sr.Close();
        }


        // Distinct By
        // var orderStatuses = containers
        //     .DistinctBy(c=> c.OrderStatus)
        //     .Select(c=> c.OrderStatus);

        var orderStatuses = from os in containers.DistinctBy(c=> c.OrderStatus)
            select os.OrderStatus;
        foreach(string status in orderStatuses) Console.WriteLine(status);


        // Group by
        var statusWiseContainers = from container in containers
            let con = new{
                Pro = container.Pro,
                Weight = container.Weight,
                Status = container.OrderStatus,
                OrderDate = container.OrderEntryDate
            }
            group con by con.Status into statusCons
            select new{
                Status = statusCons.Key,
                Containers = statusCons
            };
        
        foreach(var group in statusWiseContainers)
        {
            Console.WriteLine($"Status: {group.Status}");
            foreach(var container in group.Containers)
                Console.WriteLine($"\tPro: {container.Pro}, Weight: {container.Weight}");
        }



    }

     


 
}