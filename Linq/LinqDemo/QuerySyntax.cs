using System.Text.Json;

namespace LinqDemo;


public class QuerySyntax
{
    public IList<Container> containers;

    public QuerySyntax()
    {
        loadData();


        // all import contianser
        var vesselNotArrived = from c in containers
            where c.OrderStatus.Contains("Vessel Not Yet Arrived")
            select c;

        foreach (var container in vesselNotArrived) System.Console.WriteLine($"Pro: {container.Pro}, Consignee: {container.Consignee}, LoadType: {container.LoadType}");

 



    }



    public void loadData()
    {
        // Load Data;
        string path = Path.Combine(Environment.CurrentDirectory, "data");
        using(StreamReader sr = new StreamReader(Path.Combine(path, "container.json")))
        {
            string jsonString = sr.ReadToEnd();
            containers = JsonSerializer.Deserialize<List<Container>>(jsonString);
            sr.Close();
        }
    }
}