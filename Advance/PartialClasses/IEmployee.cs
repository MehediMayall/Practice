namespace PartialClasses;

public interface IEmployee
{

    void display();
    double GetBonus();
    static void Print()
    {
        System.Console.WriteLine($"Maximum bonus percent: {Max_Bonus}");
    }

    static double Max_Bonus= 0.20;
}