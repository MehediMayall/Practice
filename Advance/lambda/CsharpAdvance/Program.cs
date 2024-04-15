

// Func<int, int, int> getSum = (x, y) => x + y;
// Func<int, int, int> getSum = (int x, int y) => x + y;
Func<int, float, int> getSum = (int x, float y) =>  x + (int)y;

System.Console.WriteLine(getSum(10,30));


