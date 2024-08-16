using static System.Console;
using System.Threading;
bool IsPrinted = false;
Object lockPrinted = new object();


// Worker Thread
Thread th = new Thread(printHelloWorld);
th.Start();



// Main Thread
printHelloWorld();


// Shared resource without using thread lock
// void printHelloWorld()
// {
//     if ( !IsPrinted )
//     {
//         WriteLine("This message should print only once");
//         IsPrinted = true;
//     }
// }

// Shared resource  using thread lock
void printHelloWorld()
{
    lock(lockPrinted)
    {
        if ( !IsPrinted )
        {
            WriteLine("This message should print only once");
            IsPrinted = true;
        }
    }
}

