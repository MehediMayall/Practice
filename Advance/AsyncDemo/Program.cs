
using AsyncDemo;
using static System.Console;



// Make Tea
// var teaMaker = new TeaMaker();

// await teaMaker.MakeTeaAsync();

//

// WriteLine($"Task 1: Thread ID: {Thread.CurrentThread.ManagedThreadId}");
// var client = new HttpClient();

// WriteLine($"Task 2: Thread ID: {Thread.CurrentThread.ManagedThreadId}");
// var task = client.GetStringAsync("http://google.com");

// WriteLine($"Task 3: Thread ID: {Thread.CurrentThread.ManagedThreadId}");

// var a = 0;
// for(int x=0;x<1_000_000; x++)
//     a+=1;

// WriteLine($"Task 4: Thread ID: {Thread.CurrentThread.ManagedThreadId}");
// var page = await task;

// WriteLine($"Task 5: Thread ID: {Thread.CurrentThread.ManagedThreadId}");


// Parallel
var teaMaker1 = new TeaMaker();
var teaMaker2 = new TeaMaker();
var teaMaker3 = new TeaMaker();

Parallel.Invoke(
    async ()=> await teaMaker1.MakeTeaAsync(),
    async ()=> await teaMaker2.MakeTeaAsync(),
    async ()=> await teaMaker3.MakeTeaAsync()
);

