using static System.Console;

// Sample #02
int maxValue = int.MaxValue;

int result1 = unchecked(maxValue + 10);     // overflow occurs, result is the minimum int value

try
{
    int result2 = checked(maxValue + 10);
}
catch (Exception ex) { WriteLine(ex.Message); }

// Sample #01

// int maxValue = int.MaxValue;

// unchecked{
//     WriteLine($"Max Value: {maxValue}"); // print 2147483647
//     WriteLine($"Add 10 with Max Value: {maxValue +10}"); // print -2147483639
// }

// try
// {
//     checked{
//         WriteLine($"Add 10 with Max Value: {maxValue +10}"); // will throw arithmetic overflow exception
//     }

// }
// catch(Exception ex)
// {
//     WriteLine(ex.Message);
// }

bool didTheCodeRun = false;

IEnumerable<bool> RunTheCode()
{
    didTheCodeRun = true;
    yield return true;
}

IEnumerable<bool> runthis = RunTheCode();
WriteLine($"Did the code run? {didTheCodeRun}");