using static System.Console;

// // Create a SemaphoreSlim with an initial count of 3
// // and a maximum count of 5
// SemaphoreSlim semaphore = new SemaphoreSlim(3,5);
// HttpClient httpClient = new HttpClient();

// async Task ExecuteTask()
// {

//     // Simulate multiple tasks attepting to access a limited resource.
//     Task[] tasks = new Task[10];
//     for(int x=0; x <10; x++)
//     {
//         int taskID = x;
//         tasks[taskID] = Task.Run(async() =>
//         {
//             await AccessHTTPResource(taskID);
//         });

//     }

//     // Wait for all tasks to complete
//     await Task.WhenAll(tasks);
//     WriteLine("\n All Tasks Completed.");
// }

// // A method that accesses HTTP Resource
// async Task AccessHTTPResource(int TaskID)
// {
//     WriteLine($"TaskID [{TaskID}]: Started task");
//     var response = await httpClient.GetAsync("https://www.youtube.com/");
//     WriteLine($"TaskID [{TaskID}]: Browsed Youtube successfully");
// }


// // Calling the task function
// await ExecuteTask();

// class Publisher
// {
//     public event EventHandler EventOccurred;

//     public void TriggerEvent() =>
//         EventOccurred?.Invoke(this, EventArgs.Empty);
    
// }

// class Subscriber : IDisposable
// {
//     private Publisher publisher;

//     public Subscriber(Publisher publisher)
//     {
//         this.publisher = publisher;
//         publisher.EventOccurred += OnEventOccurred;
//     }

//     public void OnEventOccurred(object sender, EventArgs e) =>
//         WriteLine("Event occurred!");

//     public void Dispose()
//     {
//         // Unsubscribe from the event
//         if (publisher is null) return;

//         publisher.EventOccurred -= OnEventOccurred;
//         publisher = null;        
//     }
// }

// // Usage
// var publisher = new Publisher();
// var subscriber = new Subscriber(publisher);

// // Unsubscribe before setting to null
// subscriber.Dispose();
// subscriber = null;
// GC.Collect();
// GC.WaitForPendingFinalizers();


public class MyClass<T> where T : class
{
    public void DoSomething(T obj)
    {
        // Can call reference type methods on obj
    }
}

public interface IComparable<T>
{
    int CompareTo(T other);
}

public class MyClass<T> where T : IComparable<T>
{
    public void Compare(T x, T y)
    {
        // Can call CompareTo on x and y
    }
}

public class MyClass<T> where T : struct
{
    public void DoSomething(T value)
    {
        // Can use value type operations on value
    }
}

public class MyClass<T> where T : new()
{
    public T CreateInstance()
    {
        return new T();
    }
}


public class BaseClass { }
public class MyClass<T> where T : BaseClass
{
    public void DoSomething(T obj)
    {
        // Can access members of BaseClass on obj
    }
}