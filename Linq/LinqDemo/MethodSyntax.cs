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


        // 



    }

     


 
}