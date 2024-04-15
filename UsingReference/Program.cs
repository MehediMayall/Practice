using UsingReference;
using static System.Console;

int x = -90;
var s = new Solution();

// int *addressOfX = &x;

// s.getMemoryAddress();

WriteLine(s.getAbsoluteValue(x));

WriteLine($"Value of X: {x}");

s.getAbsoluteValue(ref x);
WriteLine($"Value of X after calling it using ref :{x}");