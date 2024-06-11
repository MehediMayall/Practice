internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 1, 2,4};
        // WorkingDays.Monday = 3;
        System.Console.WriteLine((int) Color.Green);

        System.Console.WriteLine(new Person().id);

        Point p;
        p.X = 10;

         
    }

    public class Person
    {
        public int id;
    }

    enum WorkingDays
    {
        Monday,
        Tuesday
    }
    enum Color
    {
        Red,
        Green=0,
        Blue=0,
    }

    struct Point
    {
        private int x;
        public int X{
            get { return x; }
            set { x = value; }
        }
    }
}