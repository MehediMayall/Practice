using static System.Console;



// Creating worker thread
Thread th = new Thread(printHelloWorld);
th.Start();

// blocking and joining the main thread
th.Join();
WriteLine("Hello world printed");


void printHelloWorld()
{
    WriteLine("Hello World!");
    Thread.Sleep(2000);
}

