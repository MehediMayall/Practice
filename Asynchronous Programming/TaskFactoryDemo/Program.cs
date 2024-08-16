using System.Net;
using static System.Console;


Task<string> task = Task.Factory.StartNew<string>(
    () => GetPosts("https://jsonplaceholder.typicode.com/posts")
);

try
{
    WriteLine(task.Result);
}
catch(AggregateException ex){
    WriteLine(ex.Message);
}


string GetPosts(string url)
{
    using var client = new WebClient();
    return client.DownloadString(url);
}