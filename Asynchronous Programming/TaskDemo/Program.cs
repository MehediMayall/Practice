using static System.Console;


// Creating worker thread using task
Task task = new Task(printHelloWorld);
task.Start();


// Creating another worker thread that returns a value
Task<string> taskThatReturns = new Task<string>(returnAStringValue);
taskThatReturns.Start();
taskThatReturns.Wait();

WriteLine(taskThatReturns.Result);




WriteLine("\nWaiting for user input to end");
ReadLine();


string returnAStringValue()
{
    Thread.Sleep(1000);
    return $"\nThis is the return value from the thread {Thread.CurrentThread.ManagedThreadId}";
}


void printHelloWorld()
{
    WriteLine($"Worker Thread Id: {Thread.CurrentThread.ManagedThreadId}");
    WriteLine("Hello World!\n");
}