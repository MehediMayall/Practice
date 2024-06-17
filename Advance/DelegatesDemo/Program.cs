using DelegatesDemo;

// DelegateSample.Show();

// ActionSample.Show();
// FuncSample.Show();

// PredicateSample.Show();

// FuncAnonymousSample.Show();


// Event Example
static void LogSomething(string TaskName)
{
    Console.WriteLine($"\t{TaskName}");
}

static void LogInFile(string TaskName)
{
    using(StreamWriter sw = new StreamWriter("taskLog.txt", true))
    {
        sw.WriteLine($"{DateTime.Now} : {TaskName}");
    }
}

static int CountTaskLength(string TaskName) => TaskName.Length;

// Binding event functions
EventSample.SomethingHappened += LogSomething;
EventSample.SomethingHappened += LogInFile;

EventSample.CalculateTaskLength += CountTaskLength;

EventSample.DoSomething("Wake up at 07:00 AM");
EventSample.DoSomething("Brush the teeth");
EventSample.DoSomething("Take a shower");
