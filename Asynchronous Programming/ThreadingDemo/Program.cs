using static System.Console;

WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}\n");

// Creating new worker thread
Thread th = new Thread(WriteUsingNewThread);
th.Start();


// Executing loop in main thread
for (int x=0; x< 10; x++)
{
    WriteLine($"Main thread: X = {x}");
    Thread.Sleep(50);
}


// Worker thread function
void WriteUsingNewThread()
{
    WriteLine($"\n\nWorker thread id: {Thread.CurrentThread.ManagedThreadId}\n");
    for (int x=0; x< 10; x++)
    {
        WriteLine($"\tWorker thread : X = {x}");
        Thread.Sleep(100);
    }
     
}