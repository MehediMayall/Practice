namespace MonitorLock;
using static System.Console;


public class Account
{
    public int Balance { get; set; } = 0;
    private object accountLock = new object();
    private Random random = new Random();

    public Account(int InitialBalance)
    {
        Balance = Math.Max(Balance, InitialBalance);
    }

    public int Withdraw(int amount)
    {
        if ( Balance < 0)
            throw new Exception("Not enough balance");


        // Using Monitor

        // Monitor.Enter( accountLock );
        // try
        // {
        //     if ( Balance >= amount )
        //     {
        //         Balance = Balance - amount;
        //         WriteLine($"Amount drwan: {amount.ToString().PadLeft(7)}");
        //         return Balance;
        //     }
        // }
        // finally {
        //     Monitor.Exit( accountLock );
        // }


        // Using lock
        lock( accountLock )
        {
            if ( Balance >= amount )
            {
                Balance = Balance - amount;
                WriteLine($"Amount drwan: {amount.ToString().PadLeft(6)}");
                return Balance;
            }
        }

        return 0;
    }

    public void WithdrawRandomly()
    {
        for(int x=0; x< 100; x++)
        {
            int balance = Withdraw(random.Next(2000,5000));
            if ( balance > 0)
                WriteLine($"Balance left: {balance.ToString().PadLeft(7)}"); 
        }
    }
}