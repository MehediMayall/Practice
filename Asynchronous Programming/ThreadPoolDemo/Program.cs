using static System.Console;

int processorCount = Environment.ProcessorCount;

WriteLine($"Processor #{processorCount}");
WriteLine($"Is in thread pool: {Thread.CurrentThread.IsThreadPoolThread}");


Employee employee = new("Mehedi Hasan", "A Future Company");

// Creating thread pool
ThreadPool.QueueUserWorkItem(
    new WaitCallback(DisplayEmployeeInfo), employee
);

ThreadPool.SetMaxThreads(processorCount * 2, processorCount * 2);


int workerThreads = 0;
int completionPortThreads = 0;
ThreadPool.GetMinThreads(out workerThreads, out completionPortThreads);

WriteLine($"Min thread: {workerThreads}, completion port thread: {completionPortThreads}");



void DisplayEmployeeInfo(object employee)
{
    WriteLine($"\nIs in thread pool: {Thread.CurrentThread.IsThreadPoolThread}");
    Employee emp = employee as Employee;

    WriteLine($"Name: {emp.Name}, Company: {emp.CompanyName}\n");
}



class Employee(string Name, string CompanyName)
{
    public string Name { get; set; } = Name;
    public string CompanyName { get; set; } = CompanyName;
}