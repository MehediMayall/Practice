namespace AsyncDemo;
using static System.Console;

public class TeaMaker
{
    public int makerID;
    public TeaMaker()
    {
        makerID = Thread.GetCurrentProcessorId();
    }

    // Synchronous
    public string MakeTea()
    {
        var water = BoilWater();

        WriteLine("\ttake the cups out");
        WriteLine("\tput tea in cups");

        var tea = $"\tpour {water} in cups";
        WriteLine(tea);
        return tea;
    }

    public string BoilWater()
    {
        WriteLine("Start the kettle");
        WriteLine("waiting for the kettle");
        Task.Delay(2000).GetAwaiter().GetResult();
        WriteLine("kettle finished boiling");

        return "water";
    }


    // Asynchronous
    public async Task<string> BoilWaterAsync()
    {
        WriteLine($"\tCurrent thread ID:{Thread.CurrentThread.ManagedThreadId}");
        WriteLine($"\t\tStart the kettle");
        WriteLine($"\t\twaiting for the kettle");
        await Task.Delay(2000);
        WriteLine($"\t\tkettle finished boiling");

        return "water";
    }

    public async Task<string> MakeTeaAsync()
    {        

        var boilingWater =  BoilWaterAsync();

        WriteLine("take the cups out");
        WriteLine("put tea in cups");

        var water = await boilingWater;   

        var tea = $"pour {water} in cups";
        WriteLine(tea);
        return tea;
    }

}