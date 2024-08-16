using static System.Console;
using System.Threading;
using Dumpify;


// void processData()
// {
//     WriteLine("Process started.");
//     Thread.Sleep(2000);
//     WriteLine("Process completed");
// }

// async Task printStatusCodeAsync()
// {
//     var client = new HttpClient();
//     var response = await client.GetAsync("https://www.linkedin.com");
//     WriteLine(response.StatusCode);
// }

// async Task printStatusCodeAsync()
// {
//     try
//     {

//         var client = new HttpClient();
//         // var responseTask = client.GetAsync("www.expired.badssl.com");
//         // var response = responseTask.Result;
//         var response =  await client.GetAsync("http://expired.badssl.com");
//         WriteLine(response.StatusCode);
//     }
//     catch(Exception ex)
//     {
//         WriteLine($"An exception occured. type: {ex.GetType()}");
//     }
// }


// async Task printStatusCodeAsync(CancellationToken cancellationToken)
// {
//     try
//     {

//         var client = new HttpClient();
//         // var responseTask = client.GetAsync("www.expired.badssl.com");
//         // var response = responseTask.Result;
//         var response =  await client.GetAsync("https://www.medium.com", cancellationToken);
//         WriteLine(response.StatusCode);
//     }
//     catch(Exception ex)
//     {
//         WriteLine($"An exception occured. type: {ex.GetType()}");
//     }
// }


async Task ProcessData(string[] departments, IProgress<int> progress)
{
    for (int i = 0; i< departments.Length; i++)
    {
        progress.Report(i+1);
        await Task.Delay(1000);
    }

    WriteLine("Data processing done!");
}



WriteLine("Program executing...");


// // Task.Run(processData);
// var dataTask = new Task(processData);
// dataTask.Start();


// var client = new HttpClient();
// var responseTask = client.GetAsync("https://www.linkedin.com");

 // Thread Blocking
// var content = responseTask.Result;     
// WriteLine(content.StatusCode);

// Non-blocking way
// responseTask.ContinueWith(completedTask => {
//     var content = responseTask.Result;
//     WriteLine(content.StatusCode);
// });


// var printTask = printStatusCodeAsync();
// printTask.Dump();

// using CancellationTokenSource source = new CancellationTokenSource();
// source.CancelAfter(500);
// var printTask = printStatusCodeAsync(source.Token);


// 
string[] deparments = {"Engineering", "Sales", "Marketing", "Support"};
IProgress<int> progressReport = new Progress<int>(i => WriteLine($"Processing completed: {i}"));
var dataTask = ProcessData(deparments, progressReport);

await dataTask;

WriteLine("Ready for user input");
ReadLine();
