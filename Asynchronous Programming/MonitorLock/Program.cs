using MonitorLock;
using static System.Console;


Account account = new(20000);

Task task1 = Task.Factory.StartNew(()=> account.WithdrawRandomly());
Task task2 = Task.Factory.StartNew(()=> account.WithdrawRandomly());
Task task3 = Task.Factory.StartNew(()=> account.WithdrawRandomly());
Task task4 = Task.Factory.StartNew(()=> account.WithdrawRandomly());


Task.WhenAll(task1,task2, task3, task4);

WriteLine("All tasks are completed");
