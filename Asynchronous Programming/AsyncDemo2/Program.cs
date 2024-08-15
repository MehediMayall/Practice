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


async Task printStatusCodeAsync(CancellationToken cancellationToken)
{
    try
    {

        var client = new HttpClient();
        // var responseTask = client.GetAsync("www.expired.badssl.com");
        // var response = responseTask.Result;
        var response =  await client.GetAsync("https://www.medium.com", cancellationToken);
        WriteLine(response.StatusCode);
    }
    catch(Exception ex)
    {
        WriteLine($"An exception occured. type: {ex.GetType()}");
    }
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

using CancellationTokenSource source = new CancellationTokenSource();
source.CancelAfter(500);
var printTask = printStatusCodeAsync(source.Token);


WriteLine("Ready for user input");
ReadLine();
